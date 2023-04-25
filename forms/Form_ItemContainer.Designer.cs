namespace IMS.forms
{
    partial class Form_ItemContainer
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
            label6 = new Label();
            txtDescription = new TextBox();
            label1 = new Label();
            txtCode = new TextBox();
            cbColor = new ComboBox();
            label5 = new Label();
            cbUnit = new ComboBox();
            label4 = new Label();
            cbSCategory = new ComboBox();
            label3 = new Label();
            cbCategory = new ComboBox();
            label2 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCode);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(634, 93);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item Data";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(283, 42);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 17;
            label6.Text = "Description*";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(380, 39);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(229, 27);
            txtDescription.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 42);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 6;
            label1.Text = "Item Code*";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(117, 39);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(151, 27);
            txtCode.TabIndex = 0;
            // 
            // cbColor
            // 
            cbColor.FormattingEnabled = true;
            cbColor.Items.AddRange(new object[] { "--" });
            cbColor.Location = new Point(458, 73);
            cbColor.Name = "cbColor";
            cbColor.Size = new Size(151, 28);
            cbColor.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(407, 76);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 14;
            label5.Text = "Color";
            // 
            // cbUnit
            // 
            cbUnit.FormattingEnabled = true;
            cbUnit.Items.AddRange(new object[] { "--" });
            cbUnit.Location = new Point(187, 73);
            cbUnit.Name = "cbUnit";
            cbUnit.Size = new Size(151, 28);
            cbUnit.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 76);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 12;
            label4.Text = "Unit of Measurement*";
            // 
            // cbSCategory
            // 
            cbSCategory.FormattingEnabled = true;
            cbSCategory.Items.AddRange(new object[] { "--" });
            cbSCategory.Location = new Point(458, 39);
            cbSCategory.Name = "cbSCategory";
            cbSCategory.Size = new Size(151, 28);
            cbSCategory.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 42);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 10;
            label3.Text = "Sub Category";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "--" });
            cbCategory.Location = new Point(187, 39);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(151, 28);
            cbCategory.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 42);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 8;
            label2.Text = "Category*";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(458, 242);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(558, 242);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cbCategory);
            groupBox2.Controls.Add(cbColor);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cbUnit);
            groupBox2.Controls.Add(cbSCategory);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 111);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(634, 125);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Item Description";
            // 
            // Form_ItemContainer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 284);
            Controls.Add(groupBox2);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Name = "Form_ItemContainer";
            Text = "#PLACEHOLDER";
            Load += Form_ItemContainer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtCode;
        private Label label6;
        private TextBox txtDescription;
        private ComboBox cbColor;
        private Label label5;
        private ComboBox cbUnit;
        private Label label4;
        private ComboBox cbSCategory;
        private Label label3;
        private ComboBox cbCategory;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private Button btnCancel;
        private GroupBox groupBox2;
    }
}