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
            doctorDataGridView.Location = new Point(77, 81);
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
            backBtn.Location = new Point(366, 491);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(166, 38);
            backBtn.TabIndex = 1;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += this.button1_Click;
            // 
            // DoctorListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(948, 566);
            Controls.Add(backBtn);
            Controls.Add(doctorDataGridView);
            Name = "DoctorListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoctorListForm";
            Load += this.DoctorListForm_Load;
            ((System.ComponentModel.ISupportInitialize)doctorDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView doctorDataGridView;
        private Button backBtn;
    }
}