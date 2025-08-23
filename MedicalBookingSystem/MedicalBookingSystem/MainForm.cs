namespace MedicalBookingSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bookingButton_Click(object sender, EventArgs e)
        {
            // Open AppointmentForm
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.ShowDialog();   // modal

        }

        private void appointMangementButton_Click(object sender, EventArgs e)
        {
            // Open ManageAppointmentsForm
            ManageAppointmentsForm manageForm = new ManageAppointmentsForm();
            manageForm.ShowDialog();   // modal
        }

        private void doctorViewButton_click(object sender, EventArgs e)
        {
            // Open DoctorListForm
            DoctorListForm doctorForm = new DoctorListForm();
            doctorForm.ShowDialog();   // modal
        }
    }
}
