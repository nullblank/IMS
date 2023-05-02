namespace IMS.forms.Deliveries
{
    partial class Form_Deliveries_Additem
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
            cbCategory = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cbBranch = new ComboBox();
            label7 = new Label();
            txtAmount = new TextBox();
            label4 = new Label();
            cbItem = new ComboBox();
            label3 = new Label();
            cbSCategory = new ComboBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtCost = new TextBox();
            label6 = new Label();
            cbSupplier = new ComboBox();
            label5 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cbCategory
            // 
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
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item Details";
            // 
            // cbBranch
            // 
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
            cbSCategory.FormattingEnabled = true;
            cbSCategory.Items.AddRange(new object[] { "" });
            cbSCategory.Location = new Point(374, 26);
            cbSCategory.Name = "cbSCategory";
            cbSCategory.Size = new Size(151, 28);
            cbSCategory.TabIndex = 2;
            cbSCategory.SelectedIndexChanged += cbSCategory_SelectedIndexChanged;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCost);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cbSupplier);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(12, 116);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(756, 67);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Delivery Details";
            // 
            // txtCost
            // 
            txtCost.Location = new Point(599, 26);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(151, 27);
            txtCost.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(555, 29);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 9;
            label6.Text = "Cost";
            // 
            // cbSupplier
            // 
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new Point(101, 26);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(424, 28);
            cbSupplier.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 29);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 7;
            label5.Text = "Supplier";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(574, 189);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 38);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(674, 189);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 38);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form_Deliveries_Additem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 240);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form_Deliveries_Additem";
            Text = "Add New Delivery";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbCategory;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtAmount;
        private Label label4;
        private ComboBox cbItem;
        private Label label3;
        private ComboBox cbSCategory;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox txtCost;
        private Label label6;
        private ComboBox cbSupplier;
        private Label label5;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cbBranch;
        private Label label7;
    }
}