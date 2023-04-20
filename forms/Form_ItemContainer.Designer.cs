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
            cbColor = new ComboBox();
            label5 = new Label();
            cbUnit = new ComboBox();
            label4 = new Label();
            cbSCategory = new ComboBox();
            label3 = new Label();
            cbCategory = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtCode = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(cbColor);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbUnit);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbSCategory);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbCategory);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCode);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(625, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Details";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(207, 32);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 17;
            label6.Text = "Description*";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(304, 29);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(301, 27);
            txtDescription.TabIndex = 16;
            // 
            // cbColor
            // 
            cbColor.FormattingEnabled = true;
            cbColor.Items.AddRange(new object[] { "--" });
            cbColor.Location = new Point(454, 96);
            cbColor.Name = "cbColor";
            cbColor.Size = new Size(151, 28);
            cbColor.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(403, 99);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 14;
            label5.Text = "Color";
            // 
            // cbUnit
            // 
            cbUnit.FormattingEnabled = true;
            cbUnit.Items.AddRange(new object[] { "--" });
            cbUnit.Location = new Point(166, 96);
            cbUnit.Name = "cbUnit";
            cbUnit.Size = new Size(151, 28);
            cbUnit.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 99);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 12;
            label4.Text = "Unit of Measurement*";
            // 
            // cbSCategory
            // 
            cbSCategory.FormattingEnabled = true;
            cbSCategory.Items.AddRange(new object[] { "--" });
            cbSCategory.Location = new Point(454, 62);
            cbSCategory.Name = "cbSCategory";
            cbSCategory.Size = new Size(151, 28);
            cbSCategory.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 65);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 10;
            label3.Text = "Sub Category";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "--" });
            cbCategory.Location = new Point(87, 62);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(151, 28);
            cbCategory.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 65);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 8;
            label2.Text = "Category*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 6;
            label1.Text = "Item Code*";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(96, 29);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(98, 27);
            txtCode.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(443, 162);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(543, 162);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form_ItemContainer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 202);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Name = "Form_ItemContainer";
            Text = "#PLACEHOLDER";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}