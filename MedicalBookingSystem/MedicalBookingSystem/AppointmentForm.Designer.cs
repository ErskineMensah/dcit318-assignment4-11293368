namespace MedicalBookingSystem
{
    partial class AppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            bookButton = new Button();
            backButton = new Button();
            notesTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pNameTextBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            docComboBox = new ComboBox();
            label6 = new Label();
            emailTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(225, 59);
            label1.Name = "label1";
            label1.Size = new Size(599, 48);
            label1.TabIndex = 0;
            label1.Text = "Appointment Booking Page";
            // 
            // bookButton
            // 
            bookButton.Anchor = AnchorStyles.None;
            bookButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookButton.Location = new Point(502, 635);
            bookButton.Name = "bookButton";
            bookButton.Size = new Size(214, 50);
            bookButton.TabIndex = 1;
            bookButton.Text = "Book Appointment";
            bookButton.UseVisualStyleBackColor = true;
            bookButton.Click += bookButton_Click;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.None;
            backButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            backButton.Location = new Point(295, 635);
            backButton.Name = "backButton";
            backButton.Size = new Size(146, 50);
            backButton.TabIndex = 2;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // notesTextBox
            // 
            notesTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notesTextBox.Location = new Point(131, 561);
            notesTextBox.Multiline = true;
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(792, 50);
            notesTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold);
            label2.Location = new Point(131, 518);
            label2.Name = "label2";
            label2.Size = new Size(89, 31);
            label2.TabIndex = 4;
            label2.Text = "NOTES:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold);
            label3.Location = new Point(131, 398);
            label3.Name = "label3";
            label3.Size = new Size(424, 31);
            label3.TabIndex = 5;
            label3.Text = "SELECT APPOINTMENT DATA AND TIME:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold);
            label4.Location = new Point(131, 291);
            label4.Name = "label4";
            label4.Size = new Size(247, 31);
            label4.TabIndex = 6;
            label4.Text = "ENTER PATIENT NAME:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold);
            label5.Location = new Point(131, 176);
            label5.Name = "label5";
            label5.Size = new Size(371, 31);
            label5.TabIndex = 7;
            label5.Text = "ENTER OR SELECT DOCTOR NAME:";
            // 
            // pNameTextBox
            // 
            pNameTextBox.Font = new Font("Segoe UI", 10F);
            pNameTextBox.Location = new Point(131, 336);
            pNameTextBox.Multiline = true;
            pNameTextBox.Name = "pNameTextBox";
            pNameTextBox.Size = new Size(344, 40);
            pNameTextBox.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm tt";
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(131, 451);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(258, 34);
            dateTimePicker1.TabIndex = 9;
            // 
            // docComboBox
            // 
            docComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            docComboBox.FormattingEnabled = true;
            docComboBox.Location = new Point(131, 226);
            docComboBox.Name = "docComboBox";
            docComboBox.Size = new Size(366, 36);
            docComboBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold);
            label6.Location = new Point(556, 291);
            label6.Name = "label6";
            label6.Size = new Size(220, 31);
            label6.TabIndex = 11;
            label6.Text = "ENTER EMAIL HERE:";
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.None;
            emailTextBox.Font = new Font("Segoe UI", 10F);
            emailTextBox.Location = new Point(556, 336);
            emailTextBox.Multiline = true;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(367, 40);
            emailTextBox.TabIndex = 12;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1081, 730);
            Controls.Add(emailTextBox);
            Controls.Add(label6);
            Controls.Add(docComboBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(pNameTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(notesTextBox);
            Controls.Add(backButton);
            Controls.Add(bookButton);
            Controls.Add(label1);
            Name = "AppointmentForm";
            Text = "AppointmentForm";
            Load += AppointmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bookButton;
        private Button backButton;
        private TextBox notesTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox pNameTextBox;
        private DateTimePicker dateTimePicker1;
        private ComboBox docComboBox;
        private Label label6;
        private TextBox emailTextBox;
    }
}