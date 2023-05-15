namespace IMS.forms.report
{
    partial class Form_Reports
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
            txtYear = new TextBox();
            cbMonth = new ComboBox();
            label3 = new Label();
            cbOffice = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            btnExRequests = new Button();
            groupBox2 = new GroupBox();
            btnExResupplies = new Button();
            groupBox3 = new GroupBox();
            btnExResuppliedItems = new Button();
            btnExRequestItems = new Button();
            groupBox4 = new GroupBox();
            btnBrowse = new Button();
            txtSavePath = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtYear);
            groupBox1.Controls.Add(cbMonth);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbOffice);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(644, 85);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(503, 34);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 4;
            txtYear.KeyDown += txtYear_KeyDown;
            // 
            // cbMonth
            // 
            cbMonth.FormattingEnabled = true;
            cbMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            cbMonth.Location = new Point(294, 34);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(151, 28);
            cbMonth.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(451, 37);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Year*:";
            // 
            // cbOffice
            // 
            cbOffice.FormattingEnabled = true;
            cbOffice.Location = new Point(70, 34);
            cbOffice.Name = "cbOffice";
            cbOffice.Size = new Size(151, 28);
            cbOffice.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 37);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "Month*:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 37);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Office*:";
            // 
            // btnExRequests
            // 
            btnExRequests.Location = new Point(6, 26);
            btnExRequests.Name = "btnExRequests";
            btnExRequests.Size = new Size(156, 29);
            btnExRequests.TabIndex = 1;
            btnExRequests.Text = "Export Requests";
            btnExRequests.UseVisualStyleBackColor = true;
            btnExRequests.Click += btnExRequests_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnExResupplies);
            groupBox2.Controls.Add(btnExRequests);
            groupBox2.Location = new Point(313, 194);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(343, 67);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Audit";
            // 
            // btnExResupplies
            // 
            btnExResupplies.Location = new Point(181, 26);
            btnExResupplies.Name = "btnExResupplies";
            btnExResupplies.Size = new Size(156, 29);
            btnExResupplies.TabIndex = 4;
            btnExResupplies.Text = "Export Resupplies";
            btnExResupplies.UseVisualStyleBackColor = true;
            btnExResupplies.Click += btnExResupplies_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnExResuppliedItems);
            groupBox3.Controls.Add(btnExRequestItems);
            groupBox3.Location = new Point(12, 194);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(295, 100);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dump";
            // 
            // btnExResuppliedItems
            // 
            btnExResuppliedItems.Location = new Point(6, 61);
            btnExResuppliedItems.Name = "btnExResuppliedItems";
            btnExResuppliedItems.Size = new Size(283, 29);
            btnExResuppliedItems.TabIndex = 5;
            btnExResuppliedItems.Text = "Export Resupplied Items";
            btnExResuppliedItems.UseVisualStyleBackColor = true;
            // 
            // btnExRequestItems
            // 
            btnExRequestItems.Location = new Point(6, 26);
            btnExRequestItems.Name = "btnExRequestItems";
            btnExRequestItems.Size = new Size(283, 29);
            btnExRequestItems.TabIndex = 4;
            btnExRequestItems.Text = "Export Request Items";
            btnExRequestItems.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnBrowse);
            groupBox4.Controls.Add(txtSavePath);
            groupBox4.Controls.Add(label6);
            groupBox4.Location = new Point(12, 103);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(644, 85);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Filter";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(476, 34);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(136, 29);
            btnBrowse.TabIndex = 5;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtSavePath
            // 
            txtSavePath.Location = new Point(89, 34);
            txtSavePath.Name = "txtSavePath";
            txtSavePath.ReadOnly = true;
            txtSavePath.Size = new Size(381, 27);
            txtSavePath.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 37);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 0;
            label6.Text = "Save path:";
            // 
            // Form_Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 306);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form_Reports";
            Text = "Form_Reports";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbMonth;
        private Label label3;
        private ComboBox cbOffice;
        private Label label2;
        private Label label1;
        private Button btnExRequests;
        private GroupBox groupBox2;
        private Button btnExResupplies;
        private GroupBox groupBox3;
        private Button btnExResuppliedItems;
        private Button btnExRequestItems;
        private TextBox txtYear;
        private GroupBox groupBox4;
        private Button btnBrowse;
        private TextBox txtSavePath;
        private Label label6;
    }
}