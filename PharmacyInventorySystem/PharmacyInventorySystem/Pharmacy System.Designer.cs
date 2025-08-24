namespace PharmacyInventorySystem
{
    partial class PharmacySystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmacySystem));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nameTextBox = new TextBox();
            categoryTextBox = new TextBox();
            priceTextBox = new TextBox();
            quantityTextBox = new TextBox();
            label6 = new Label();
            searchTextBox = new TextBox();
            catSearchBtn = new Button();
            nameSearchBtn = new Button();
            dataGridView1 = new DataGridView();
            addMedBtn = new Button();
            updateBtn = new Button();
            purchaseBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(398, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(416, 106);
            label1.Name = "label1";
            label1.Size = new Size(264, 31);
            label1.TabIndex = 1;
            label1.Text = "Investory System";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(63, 173);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 2;
            label2.Text = "NAME:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(385, 173);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 3;
            label3.Text = "CATEGORY:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(688, 173);
            label4.Name = "label4";
            label4.Size = new Size(124, 28);
            label4.TabIndex = 4;
            label4.Text = "PRICE(GHC):";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(916, 173);
            label5.Name = "label5";
            label5.Size = new Size(158, 28);
            label5.TabIndex = 5;
            label5.Text = "QUANTITY(mg):";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.None;
            nameTextBox.Location = new Point(63, 219);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(271, 45);
            nameTextBox.TabIndex = 6;
            // 
            // categoryTextBox
            // 
            categoryTextBox.Anchor = AnchorStyles.None;
            categoryTextBox.Location = new Point(385, 219);
            categoryTextBox.Multiline = true;
            categoryTextBox.Name = "categoryTextBox";
            categoryTextBox.Size = new Size(243, 45);
            categoryTextBox.TabIndex = 7;
            // 
            // priceTextBox
            // 
            priceTextBox.Anchor = AnchorStyles.None;
            priceTextBox.Location = new Point(688, 219);
            priceTextBox.Multiline = true;
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(172, 45);
            priceTextBox.TabIndex = 8;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Anchor = AnchorStyles.None;
            quantityTextBox.Location = new Point(922, 219);
            quantityTextBox.Multiline = true;
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(152, 45);
            quantityTextBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(68, 372);
            label6.Name = "label6";
            label6.Size = new Size(90, 28);
            label6.TabIndex = 10;
            label6.Text = "SEARCH:";
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.None;
            searchTextBox.Location = new Point(68, 420);
            searchTextBox.Multiline = true;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(437, 45);
            searchTextBox.TabIndex = 11;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // catSearchBtn
            // 
            catSearchBtn.Anchor = AnchorStyles.None;
            catSearchBtn.Font = new Font("Segoe UI", 10F);
            catSearchBtn.Location = new Point(554, 420);
            catSearchBtn.Name = "catSearchBtn";
            catSearchBtn.Size = new Size(243, 45);
            catSearchBtn.TabIndex = 12;
            catSearchBtn.Text = "SEARCH BY CATEGORY";
            catSearchBtn.UseVisualStyleBackColor = true;
            catSearchBtn.Click += seacrhCatBtn;
            // 
            // nameSearchBtn
            // 
            nameSearchBtn.Anchor = AnchorStyles.None;
            nameSearchBtn.Font = new Font("Segoe UI", 10F);
            nameSearchBtn.Location = new Point(827, 420);
            nameSearchBtn.Name = "nameSearchBtn";
            nameSearchBtn.Size = new Size(246, 45);
            nameSearchBtn.TabIndex = 13;
            nameSearchBtn.Text = "SEARCH BY NAME";
            nameSearchBtn.UseVisualStyleBackColor = true;
            nameSearchBtn.Click += searchNameBtn;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(69, 532);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1005, 272);
            dataGridView1.TabIndex = 14;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // addMedBtn
            // 
            addMedBtn.Anchor = AnchorStyles.None;
            addMedBtn.Font = new Font("Segoe UI", 10F);
            addMedBtn.Location = new Point(857, 295);
            addMedBtn.Name = "addMedBtn";
            addMedBtn.Size = new Size(216, 45);
            addMedBtn.TabIndex = 15;
            addMedBtn.Text = "ADD NEW MEDICINE";
            addMedBtn.UseVisualStyleBackColor = true;
            addMedBtn.Click += addMedBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Anchor = AnchorStyles.None;
            updateBtn.Font = new Font("Segoe UI", 10F);
            updateBtn.Location = new Point(827, 845);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(246, 53);
            updateBtn.TabIndex = 16;
            updateBtn.Text = "UPDATE STOCK";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // purchaseBtn
            // 
            purchaseBtn.Font = new Font("Segoe UI", 10F);
            purchaseBtn.Location = new Point(650, 295);
            purchaseBtn.Name = "purchaseBtn";
            purchaseBtn.Size = new Size(186, 45);
            purchaseBtn.TabIndex = 17;
            purchaseBtn.Text = "RECORD PURCHASE";
            purchaseBtn.UseVisualStyleBackColor = true;
            purchaseBtn.Click += purchaseBtn_Click;
            // 
            // PharmacySystem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1133, 974);
            Controls.Add(purchaseBtn);
            Controls.Add(updateBtn);
            Controls.Add(addMedBtn);
            Controls.Add(dataGridView1);
            Controls.Add(nameSearchBtn);
            Controls.Add(catSearchBtn);
            Controls.Add(searchTextBox);
            Controls.Add(label6);
            Controls.Add(quantityTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(categoryTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "PharmacySystem";
            Text = "Pharmacy System";
            Load += PharmacySystem_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox nameTextBox;
        private TextBox categoryTextBox;
        private TextBox priceTextBox;
        private TextBox quantityTextBox;
        private Label label6;
        private TextBox searchTextBox;
        private Button catSearchBtn;
        private Button nameSearchBtn;
        private DataGridView dataGridView1;
        private Button addMedBtn;
        private Button updateBtn;
        private Button purchaseBtn;
    }
}