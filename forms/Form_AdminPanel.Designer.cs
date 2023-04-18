namespace IMS.forms
{
    partial class Form_AdminPanel
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
            btnLogs = new Button();
            btnLogout = new Button();
            btnUsers = new Button();
            btnSCAT = new Button();
            btnSCA = new Button();
            btnSCOL = new Button();
            btnSUNT = new Button();
            btnOFF = new Button();
            btnSUP = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnLogs
            // 
            btnLogs.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnLogs.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogs.Location = new Point(58, 370);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(272, 30);
            btnLogs.TabIndex = 0;
            btnLogs.Text = "View Logs";
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.Location = new Point(58, 444);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(272, 30);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            btnUsers.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnUsers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUsers.Location = new Point(58, 54);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(272, 30);
            btnUsers.TabIndex = 2;
            btnUsers.Text = "Manage Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnSCAT
            // 
            btnSCAT.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSCAT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSCAT.Location = new Point(58, 120);
            btnSCAT.Name = "btnSCAT";
            btnSCAT.Size = new Size(272, 30);
            btnSCAT.TabIndex = 3;
            btnSCAT.Text = "Manage Supply Category";
            btnSCAT.UseVisualStyleBackColor = true;
            btnSCAT.Click += btnSCAT_Click;
            // 
            // btnSCA
            // 
            btnSCA.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSCA.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSCA.Location = new Point(58, 156);
            btnSCA.Name = "btnSCA";
            btnSCA.Size = new Size(272, 30);
            btnSCA.TabIndex = 4;
            btnSCA.Text = "Manage Supply Sub Category";
            btnSCA.UseVisualStyleBackColor = true;
            btnSCA.Click += btnSCA_Click;
            // 
            // btnSCOL
            // 
            btnSCOL.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSCOL.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSCOL.Location = new Point(58, 192);
            btnSCOL.Name = "btnSCOL";
            btnSCOL.Size = new Size(272, 30);
            btnSCOL.TabIndex = 5;
            btnSCOL.Text = "Manage Supply Colors";
            btnSCOL.UseVisualStyleBackColor = true;
            btnSCOL.Click += btnSCOL_Click;
            // 
            // btnSUNT
            // 
            btnSUNT.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSUNT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSUNT.Location = new Point(58, 228);
            btnSUNT.Name = "btnSUNT";
            btnSUNT.Size = new Size(272, 30);
            btnSUNT.TabIndex = 6;
            btnSUNT.Text = "Manage Supply Unit";
            btnSUNT.UseVisualStyleBackColor = true;
            btnSUNT.Click += btnSUNT_Click;
            // 
            // btnOFF
            // 
            btnOFF.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnOFF.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOFF.Location = new Point(58, 264);
            btnOFF.Name = "btnOFF";
            btnOFF.Size = new Size(272, 30);
            btnOFF.TabIndex = 7;
            btnOFF.Text = "Manage Offices";
            btnOFF.UseVisualStyleBackColor = true;
            btnOFF.Click += btnOFF_Click;
            // 
            // btnSUP
            // 
            btnSUP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSUP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSUP.Location = new Point(58, 300);
            btnSUP.Name = "btnSUP";
            btnSUP.Size = new Size(272, 30);
            btnSUP.TabIndex = 8;
            btnSUP.Text = "Manage Suppliers";
            btnSUP.UseVisualStyleBackColor = true;
            btnSUP.Click += btnSUP_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(58, 31);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 9;
            label1.Text = "Main";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(58, 97);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 10;
            label2.Text = "References";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(58, 347);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 11;
            label3.Text = "Misc.";
            // 
            // Form_AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 510);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSUP);
            Controls.Add(btnOFF);
            Controls.Add(btnSUNT);
            Controls.Add(btnSCOL);
            Controls.Add(btnSCA);
            Controls.Add(btnSCAT);
            Controls.Add(btnUsers);
            Controls.Add(btnLogs);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form_AdminPanel";
            Text = "IMS Developer's Panel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogs;
        private Button btnLogout;
        private Button btnUsers;
        private Button btnSCAT;
        private Button btnSCA;
        private Button btnSCOL;
        private Button btnSUNT;
        private Button btnOFF;
        private Button btnSUP;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}