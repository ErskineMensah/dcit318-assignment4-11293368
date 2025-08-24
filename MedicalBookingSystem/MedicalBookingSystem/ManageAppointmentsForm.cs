using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace MedicalBookingSystem
{
    public partial class ManageAppointmentsForm : Form
    {
        public ManageAppointmentsForm()
        {
            InitializeComponent();
        }

        private void LoadAppointmentsData()
        {
            try
            {
                string query = @"
                SELECT 
                    a.AppointmentID,
                    d.FullName AS DoctorName,
                    p.FullName AS PatientName,
                    p.Email AS PatientEmail,
                    a.AppointmentDate,
                    a.Notes
                FROM Appointments a
                INNER JOIN Doctors d ON a.DoctorID = d.DoctorID
                INNER JOIN Patients p ON a.PatientID = p.PatientID
                ORDER BY a.AppointmentDate DESC;";

                DataTable appointmentsTable = DatabaseHelper.GetDataTable(query);
                manageAGridView.DataSource = appointmentsTable;

                if (manageAGridView.Columns["AppointmentID"] != null)
                    manageAGridView.Columns["AppointmentID"].HeaderText = "Appointment ID";
                if (manageAGridView.Columns["DoctorName"] != null)
                    manageAGridView.Columns["DoctorName"].HeaderText = "Doctor";
                if (manageAGridView.Columns["PatientName"] != null)
                    manageAGridView.Columns["PatientName"].HeaderText = "Patient";
                if (manageAGridView.Columns["PatientEmail"] != null)
                    manageAGridView.Columns["PatientEmail"].HeaderText = "Patient Email";
                if (manageAGridView.Columns["AppointmentDate"] != null)
                    manageAGridView.Columns["AppointmentDate"].HeaderText = "Date & Time";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading appointments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSelectedAppointmentId()
        {
            if (manageAGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
            
            return Convert.ToInt32(manageAGridView.SelectedRows[0].Cells["AppointmentID"].Value);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int appointmentId = GetSelectedAppointmentId();
            if (appointmentId == -1) return;

           
            DataGridViewRow selectedRow = manageAGridView.SelectedRows[0];
            DateTime currentDate = Convert.ToDateTime(selectedRow.Cells["AppointmentDate"].Value);

          
            string prompt = $"Enter new date and time for Appointment ID {appointmentId}:";
            string title = "Update Appointment Date";
            DateTime newDate = currentDate; 

            newDate = currentDate.AddDays(1);

            var confirmResult = MessageBox.Show($"Change appointment date from {currentDate} to {newDate}?",
                                                "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    
                    string updateSql = "UPDATE Appointments SET AppointmentDate = @AppointmentDate WHERE AppointmentID = @AppointmentID";

                    SqlParameter[] parameters = {
                        new SqlParameter("@AppointmentDate", SqlDbType.DateTime) { Value = newDate },
                        new SqlParameter("@AppointmentID", SqlDbType.Int) { Value = appointmentId }
                    };

                    int rowsAffected = DatabaseHelper.ExecuteNonQuery(updateSql, parameters: parameters);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Appointment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAppointmentsData(); 
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating appointment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int appointmentId = GetSelectedAppointmentId();
            if (appointmentId == -1) return;

            var result = MessageBox.Show("Are you sure you want to delete this appointment? This action cannot be undone.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string deleteSql = "DELETE FROM Appointments WHERE AppointmentID = @AppointmentID";

                    SqlParameter[] parameters = {
                        new SqlParameter("@AppointmentID", SqlDbType.Int) { Value = appointmentId }
                    };

                    int rowsAffected = DatabaseHelper.ExecuteNonQuery(deleteSql, parameters: parameters);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Appointment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAppointmentsData(); 
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting appointment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageAppointmentsForm_Load(object sender, EventArgs e)
        {
            LoadAppointmentsData();
        }

        
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadAppointmentsData();
        }
    }
}