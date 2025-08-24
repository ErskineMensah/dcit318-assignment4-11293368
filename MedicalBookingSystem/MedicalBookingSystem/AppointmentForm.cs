using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace MedicalBookingSystem
{

    public class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public KeyValuePair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }

    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void LoadDoctorsComboBox()
        {
            try
            {
                string query = "SELECT DoctorID, FullName FROM Doctors WHERE Availability = 1;";

                using (var reader = DatabaseHelper.ExecuteReader(query))
                {
                    docComboBox.Items.Clear();

                    while (reader.Read())
                    {
                        docComboBox.Items.Add(new KeyValuePair<int, string>(
                            reader.GetInt32(0),    
                            reader.GetString(1))); 
                    }
                }

                docComboBox.DisplayMember = "Value";
                docComboBox.ValueMember = "Key";

                if (docComboBox.Items.Count > 0)
                {
                    docComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading doctors: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void bookButton_Click(object sender, EventArgs e)
        {
            if (docComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(pNameTextBox.Text))
            {
                MessageBox.Show("Please enter patient name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pNameTextBox.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(emailTextBox.Text) || !emailTextBox.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailTextBox.Focus();
                return;
            }
            if (dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("Please select a future date and time for the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker1.Focus();
                return;
            }

            int selectedDoctorId = ((KeyValuePair<int, string>)docComboBox.SelectedItem).Key;
            string patientName = pNameTextBox.Text.Trim();
            string patientEmail = emailTextBox.Text.Trim();
            DateTime appointmentDate = dateTimePicker1.Value;
            string notes = notesTextBox.Text;

            try
            {
                string checkAvailabilitySql = "SELECT Availability FROM Doctors WHERE DoctorID = @DoctorID";
                bool isDoctorAvailable = false;

                using (var connection = DatabaseHelper.GetConnection())
                using (var command = new SqlCommand(checkAvailabilitySql, connection))
                {
                    command.Parameters.AddWithValue("@DoctorID", selectedDoctorId);
                    var result = command.ExecuteScalar();
                    isDoctorAvailable = result != null && (bool)result;
                }

                if (!isDoctorAvailable)
                {
                    MessageBox.Show("The selected doctor is not available for new appointments.", "Doctor Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string insertAppointmentSql = @"
        DECLARE @PatientID INT;
        SELECT @PatientID = PatientID FROM Patients WHERE Email = @Email;
        
        IF @PatientID IS NULL
        BEGIN
            INSERT INTO Patients (FullName, Email) VALUES (@FullName, @Email);
            SET @PatientID = SCOPE_IDENTITY();
        END

        INSERT INTO Appointments (DoctorID, PatientID, AppointmentDate, Notes)
        VALUES (@DoctorID, @PatientID, @AppointmentDate, @Notes);
        ";

                SqlParameter[] parameters = {
            new SqlParameter("@FullName", SqlDbType.VarChar) { Value = patientName },
            new SqlParameter("@Email", SqlDbType.VarChar) { Value = patientEmail },
            new SqlParameter("@DoctorID", SqlDbType.Int) { Value = selectedDoctorId },
            new SqlParameter("@AppointmentDate", SqlDbType.DateTime) { Value = appointmentDate },
            new SqlParameter("@Notes", SqlDbType.VarChar) { Value = (object)notes ?? DBNull.Value }
        };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(insertAppointmentSql, parameters: parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Appointment booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to book the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while booking the appointment: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppointmentForm_Load(object sender, EventArgs e) {
            LoadDoctorsComboBox();
            dateTimePicker1.Value = DateTime.Now.AddHours(1);
        }
    }
}
