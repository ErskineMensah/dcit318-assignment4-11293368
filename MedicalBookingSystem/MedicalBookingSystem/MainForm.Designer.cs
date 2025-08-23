namespace MedicalBookingSystem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            bookingButton = new Button();
            appointMangementButton = new Button();
            doctorViewButton = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bookingButton
            // 
            bookingButton.Anchor = AnchorStyles.None;
            bookingButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookingButton.Location = new Point(56, 249);
            bookingButton.Name = "bookingButton";
            bookingButton.Size = new Size(346, 62);
            bookingButton.TabIndex = 0;
            bookingButton.Text = "Book An Appointment";
            bookingButton.UseVisualStyleBackColor = true;
            bookingButton.Click += bookingButton_Click;
            // 
            // appointMangementButton
            // 
            appointMangementButton.Anchor = AnchorStyles.None;
            appointMangementButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointMangementButton.Location = new Point(444, 249);
            appointMangementButton.Name = "appointMangementButton";
            appointMangementButton.Size = new Size(348, 62);
            appointMangementButton.TabIndex = 1;
            appointMangementButton.Text = "Appointments Management\n";
            appointMangementButton.UseVisualStyleBackColor = true;
            appointMangementButton.Click += appointMangementButton_Click;
            // 
            // doctorViewButton
            // 
            doctorViewButton.Anchor = AnchorStyles.None;
            doctorViewButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doctorViewButton.Location = new Point(220, 334);
            doctorViewButton.Name = "doctorViewButton";
            doctorViewButton.Size = new Size(387, 62);
            doctorViewButton.TabIndex = 2;
            doctorViewButton.Text = "View Available Doctors";
            doctorViewButton.UseVisualStyleBackColor = true;
            doctorViewButton.Click += doctorViewButton_click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(291, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 201);
            label1.Name = "label1";
            label1.Size = new Size(672, 31);
            label1.TabIndex = 4;
            label1.Text = "Welcome To The Booking System, Please Click On A Button To Continue:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans Ultra Bold", 24F);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(110, 135);
            label2.Name = "label2";
            label2.Size = new Size(626, 56);
            label2.TabIndex = 5;
            label2.Text = "Medical Booking System";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(847, 469);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(doctorViewButton);
            Controls.Add(appointMangementButton);
            Controls.Add(bookingButton);
            Name = "MainForm";
            Text = "MainForm";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bookingButton;
        private Button appointMangementButton;
        private Button doctorViewButton;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}
