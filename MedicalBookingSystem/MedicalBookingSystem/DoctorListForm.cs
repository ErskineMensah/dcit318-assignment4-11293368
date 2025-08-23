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
    public partial class DoctorListForm : Form
    {
        public DoctorListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoctorListForm_Load(object sender, EventArgs e) { }
    }
}
