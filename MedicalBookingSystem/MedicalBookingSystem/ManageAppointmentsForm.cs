using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalBookingSystem
{
    public partial class ManageAppointmentsForm : Form
    {
        public ManageAppointmentsForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update button clicked (test only)");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete button clicked (test only)");
        }

        private void ManageAppointmentsForm_Load(object sender, EventArgs e) { }
    }
}
