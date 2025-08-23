namespace MedicalBookingSystem
{
    partial class DoctorListForm
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
            doctorDataGridView = new DataGridView();
            backBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)doctorDataGridView).BeginInit();
            SuspendLayout();
            // 
            // doctorDataGridView
            // 
            doctorDataGridView.AllowUserToAddRows = false;
            doctorDataGridView.AllowUserToDeleteRows = false;
            doctorDataGridView.Anchor = AnchorStyles.None;
            doctorDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            doctorDataGridView.BackgroundColor = Color.White;
            doctorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctorDataGridView.GridColor = SystemColors.ScrollBar;
            doctorDataGridView.Location = new Point(80, 156);
            doctorDataGridView.Name = "doctorDataGridView";
            doctorDataGridView.ReadOnly = true;
            doctorDataGridView.RowHeadersWidth = 51;
            doctorDataGridView.Size = new Size(786, 371);
            doctorDataGridView.TabIndex = 0;
            // 
            // backBtn
            // 
            backBtn.Anchor = AnchorStyles.None;
            backBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.Location = new Point(378, 554);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(166, 38);
            backBtn.TabIndex = 1;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 19.8000011F);
            label1.Location = new Point(233, 82);
            label1.Name = "label1";
            label1.Size = new Size(452, 48);
            label1.TabIndex = 2;
            label1.Text = "Doctors Information";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DoctorListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(948, 623);
            Controls.Add(label1);
            Controls.Add(backBtn);
            Controls.Add(doctorDataGridView);
            Name = "DoctorListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoctorListForm";
            FormClosed += backBtn_Click;
            Load += DoctorListForm_Load;
            ((System.ComponentModel.ISupportInitialize)doctorDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView doctorDataGridView;
        private Button backBtn;
        private Label label1;
    }
}