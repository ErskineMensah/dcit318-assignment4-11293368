using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; 

namespace MedicalBookingSystem
{
    public partial class DoctorListForm : Form
    {
        public DoctorListForm()
        {
            InitializeComponent();
        }

        private void LoadDoctorsData()
        {
            try
            {
                string query = "SELECT DoctorID, FullName, Specialty, Availability FROM Doctors;";

                DataTable doctorsTable = DatabaseHelper.GetDataTable(query);

                doctorDataGridView.DataSource = doctorsTable;

                if (doctorDataGridView.Columns["Availability"] != null)
                {
                    doctorDataGridView.Columns["Availability"].HeaderText = "Is Available?";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading doctors: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoctorListForm_Load(object sender, EventArgs e) {
            LoadDoctorsData();
        }
    }
}
