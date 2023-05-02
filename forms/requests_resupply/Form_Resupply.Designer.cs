namespace IMS.forms.requests_resupply
{
    partial class Form_Resupply
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
            groupBox1 = new GroupBox();
            cbBranch = new ComboBox();
            label7 = new Label();
            txtAmount = new TextBox();
            label4 = new Label();
            cbItem = new ComboBox();
            label3 = new Label();
            cbSCategory = new ComboBox();
            label2 = new Label();
            cbCategory = new ComboBox();
            label1 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbBranch);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbItem);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbSCategory);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbCategory);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(756, 98);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item Details";
            // 
            // cbBranch
            // 
            cbBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBranch.FormattingEnabled = true;
            cbBranch.Location = new Point(599, 60);
            cbBranch.Name = "cbBranch";
            cbBranch.Size = new Size(151, 28);
            cbBranch.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(539, 63);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 9;
            label7.Text = "Branch";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(599, 27);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(151, 27);
            txtAmount.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(531, 30);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 7;
            label4.Text = "Amount";
            // 
            // cbItem
            // 
            cbItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbItem.FormattingEnabled = true;
            cbItem.Location = new Point(101, 60);
            cbItem.Name = "cbItem";
            cbItem.Size = new Size(424, 28);
            cbItem.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 63);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 5;
            label3.Text = "Item Name";
            // 
            // cbSCategory
            // 
            cbSCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSCategory.FormattingEnabled = true;
            cbSCategory.Items.AddRange(new object[] { "" });
            cbSCategory.Location = new Point(374, 26);
            cbSCategory.Name = "cbSCategory";
            cbSCategory.Size = new Size(151, 28);
            cbSCategory.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 29);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 3;
            label2.Text = "Subcategory";
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(101, 26);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(151, 28);
            cbCategory.TabIndex = 0;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 29);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Category";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(675, 116);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 38);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(575, 116);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 38);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // Form_Resupply
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 164);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Name = "Form_Resupply";
            Text = "Form_Resupply";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbBranch;
        private Label label7;
        private TextBox txtAmount;
        private Label label4;
        private ComboBox cbItem;
        private Label label3;
        private ComboBox cbSCategory;
        private Label label2;
        private ComboBox cbCategory;
        private Label label1;
        private Button btnCancel;
        private Button btnSave;
    }
}