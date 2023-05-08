namespace IMS.forms.requests_deliveries
{
    partial class Form_Outbound
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
            dgvRequests = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox3 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtRequestNumber = new TextBox();
            txtPurpose = new TextBox();
            txtOffice = new TextBox();
            txtUser = new TextBox();
            groupBox4 = new GroupBox();
            lvItems = new ListView();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRequests
            // 
            dgvRequests.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.Location = new Point(6, 26);
            dgvRequests.Name = "dgvRequests";
            dgvRequests.RowHeadersWidth = 51;
            dgvRequests.RowTemplate.Height = 29;
            dgvRequests.Size = new Size(384, 490);
            dgvRequests.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvRequests);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 522);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Requests";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(713, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(177, 522);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Controls";
            // 
            // button4
            // 
            button4.Location = new Point(6, 131);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(6, 96);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(6, 61);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 26);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtUser);
            groupBox3.Controls.Add(txtOffice);
            groupBox3.Controls.Add(txtPurpose);
            groupBox3.Controls.Add(txtRequestNumber);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(414, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(293, 178);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Information";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 128);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 5;
            label4.Text = "User:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 95);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 4;
            label3.Text = "Office:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 62);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Purpose:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 29);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Request#:";
            // 
            // txtRequestNumber
            // 
            txtRequestNumber.Location = new Point(95, 26);
            txtRequestNumber.Name = "txtRequestNumber";
            txtRequestNumber.ReadOnly = true;
            txtRequestNumber.Size = new Size(125, 27);
            txtRequestNumber.TabIndex = 10;
            // 
            // txtPurpose
            // 
            txtPurpose.Location = new Point(95, 59);
            txtPurpose.Name = "txtPurpose";
            txtPurpose.ReadOnly = true;
            txtPurpose.Size = new Size(125, 27);
            txtPurpose.TabIndex = 11;
            // 
            // txtOffice
            // 
            txtOffice.Location = new Point(95, 92);
            txtOffice.Name = "txtOffice";
            txtOffice.ReadOnly = true;
            txtOffice.Size = new Size(125, 27);
            txtOffice.TabIndex = 12;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(95, 125);
            txtUser.Name = "txtUser";
            txtUser.ReadOnly = true;
            txtUser.Size = new Size(125, 27);
            txtUser.TabIndex = 13;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lvItems);
            groupBox4.Location = new Point(414, 196);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(293, 338);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Items";
            // 
            // lvItems
            // 
            lvItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvItems.Location = new Point(6, 26);
            lvItems.Name = "lvItems";
            lvItems.Size = new Size(281, 306);
            lvItems.TabIndex = 0;
            lvItems.UseCompatibleStateImageBehavior = false;
            // 
            // Form_Outbound
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 546);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form_Outbound";
            Text = "Form_Outbound";
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRequests;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtUser;
        private TextBox txtOffice;
        private TextBox txtPurpose;
        private TextBox txtRequestNumber;
        private GroupBox groupBox4;
        private ListView lvItems;
    }
}