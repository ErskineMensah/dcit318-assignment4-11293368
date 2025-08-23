namespace MedicalBookingSystem
{
    partial class ManageAppointmentsForm
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
            manageAGridView = new DataGridView();
            backButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)manageAGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 19.8000011F);
            label1.Location = new Point(154, 74);
            label1.Name = "label1";
            label1.Size = new Size(720, 48);
            label1.TabIndex = 0;
            label1.Text = "Appointments Management Page";
            // 
            // manageAGridView
            // 
            manageAGridView.Anchor = AnchorStyles.None;
            manageAGridView.BackgroundColor = Color.White;
            manageAGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            manageAGridView.GridColor = SystemColors.ScrollBar;
            manageAGridView.Location = new Point(63, 145);
            manageAGridView.Name = "manageAGridView";
            manageAGridView.RowHeadersWidth = 51;
            manageAGridView.Size = new Size(931, 368);
            manageAGridView.TabIndex = 1;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.None;
            backButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.Location = new Point(63, 544);
            backButton.Name = "backButton";
            backButton.Size = new Size(199, 51);
            backButton.TabIndex = 2;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += this.backBtn_Click;
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.None;
            updateButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            updateButton.Location = new Point(802, 544);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(192, 51);
            updateButton.TabIndex = 3;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += this.updateBtn_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            deleteButton.Location = new Point(584, 544);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(191, 51);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += this.deleteBtn_Click;
            // 
            // ManageAppointmentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1060, 649);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(backButton);
            Controls.Add(manageAGridView);
            Controls.Add(label1);
            Name = "ManageAppointmentsForm";
            Text = "ManageAppointmentsForm";
            Load += this.ManageAppointmentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)manageAGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView manageAGridView;
        private Button backButton;
        private Button updateButton;
        private Button deleteButton;
    }
}