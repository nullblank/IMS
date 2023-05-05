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
            btnMasterList = new Button();
            groupBox1 = new GroupBox();
            btnRealReSupply = new Button();
            btnResupply = new Button();
            btnDeliveries = new Button();
            groupBox2 = new GroupBox();
            btnBranch = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogs
            // 
            btnLogs.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogs.Location = new Point(6, 26);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(260, 30);
            btnLogs.TabIndex = 0;
            btnLogs.Text = "View Logs";
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.Location = new Point(59, 600);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(259, 30);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUsers
            // 
            btnUsers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUsers.Location = new Point(6, 26);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(260, 30);
            btnUsers.TabIndex = 2;
            btnUsers.Text = "Manage Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnSCAT
            // 
            btnSCAT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSCAT.Location = new Point(6, 26);
            btnSCAT.Name = "btnSCAT";
            btnSCAT.Size = new Size(260, 30);
            btnSCAT.TabIndex = 3;
            btnSCAT.Text = "Manage Supply Category";
            btnSCAT.UseVisualStyleBackColor = true;
            btnSCAT.Click += btnSCAT_Click;
            // 
            // btnSCA
            // 
            btnSCA.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSCA.Location = new Point(6, 62);
            btnSCA.Name = "btnSCA";
            btnSCA.Size = new Size(260, 30);
            btnSCA.TabIndex = 4;
            btnSCA.Text = "Manage Supply Sub Category";
            btnSCA.UseVisualStyleBackColor = true;
            btnSCA.Click += btnSCA_Click;
            // 
            // btnSCOL
            // 
            btnSCOL.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSCOL.Location = new Point(6, 98);
            btnSCOL.Name = "btnSCOL";
            btnSCOL.Size = new Size(260, 30);
            btnSCOL.TabIndex = 5;
            btnSCOL.Text = "Manage Supply Colors";
            btnSCOL.UseVisualStyleBackColor = true;
            btnSCOL.Click += btnSCOL_Click;
            // 
            // btnSUNT
            // 
            btnSUNT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSUNT.Location = new Point(6, 134);
            btnSUNT.Name = "btnSUNT";
            btnSUNT.Size = new Size(260, 30);
            btnSUNT.TabIndex = 6;
            btnSUNT.Text = "Manage Supply Unit";
            btnSUNT.UseVisualStyleBackColor = true;
            btnSUNT.Click += btnSUNT_Click;
            // 
            // btnOFF
            // 
            btnOFF.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOFF.Location = new Point(6, 170);
            btnOFF.Name = "btnOFF";
            btnOFF.Size = new Size(260, 30);
            btnOFF.TabIndex = 7;
            btnOFF.Text = "Manage Offices";
            btnOFF.UseVisualStyleBackColor = true;
            btnOFF.Click += btnOFF_Click;
            // 
            // btnSUP
            // 
            btnSUP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSUP.Location = new Point(6, 206);
            btnSUP.Name = "btnSUP";
            btnSUP.Size = new Size(260, 30);
            btnSUP.TabIndex = 8;
            btnSUP.Text = "Manage Suppliers";
            btnSUP.UseVisualStyleBackColor = true;
            btnSUP.Click += btnSUP_Click;
            // 
            // btnMasterList
            // 
            btnMasterList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMasterList.Location = new Point(6, 62);
            btnMasterList.Name = "btnMasterList";
            btnMasterList.Size = new Size(260, 30);
            btnMasterList.TabIndex = 12;
            btnMasterList.Text = "Master Stockpile List";
            btnMasterList.UseVisualStyleBackColor = true;
            btnMasterList.Click += btnMasterList_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRealReSupply);
            groupBox1.Controls.Add(btnResupply);
            groupBox1.Controls.Add(btnDeliveries);
            groupBox1.Controls.Add(btnMasterList);
            groupBox1.Controls.Add(btnUsers);
            groupBox1.Location = new Point(53, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 225);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Main";
            // 
            // btnRealReSupply
            // 
            btnRealReSupply.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRealReSupply.Location = new Point(7, 170);
            btnRealReSupply.Name = "btnRealReSupply";
            btnRealReSupply.Size = new Size(259, 30);
            btnRealReSupply.TabIndex = 18;
            btnRealReSupply.Text = "Open Resupply Panel";
            btnRealReSupply.UseVisualStyleBackColor = true;
            btnRealReSupply.Click += btnRealReSupply_Click;
            // 
            // btnResupply
            // 
            btnResupply.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnResupply.Location = new Point(6, 134);
            btnResupply.Name = "btnResupply";
            btnResupply.Size = new Size(259, 30);
            btnResupply.TabIndex = 17;
            btnResupply.Text = "Open Requests Panel";
            btnResupply.UseVisualStyleBackColor = true;
            btnResupply.Click += btnResupply_Click;
            // 
            // btnDeliveries
            // 
            btnDeliveries.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeliveries.Location = new Point(6, 98);
            btnDeliveries.Name = "btnDeliveries";
            btnDeliveries.Size = new Size(259, 30);
            btnDeliveries.TabIndex = 16;
            btnDeliveries.Text = "Deliveries Log";
            btnDeliveries.UseVisualStyleBackColor = true;
            btnDeliveries.Click += btnDeliveries_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBranch);
            groupBox2.Controls.Add(btnSCAT);
            groupBox2.Controls.Add(btnSCA);
            groupBox2.Controls.Add(btnSCOL);
            groupBox2.Controls.Add(btnSUNT);
            groupBox2.Controls.Add(btnSUP);
            groupBox2.Controls.Add(btnOFF);
            groupBox2.Location = new Point(53, 243);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(272, 282);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "References";
            // 
            // btnBranch
            // 
            btnBranch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBranch.Location = new Point(6, 242);
            btnBranch.Name = "btnBranch";
            btnBranch.Size = new Size(259, 30);
            btnBranch.TabIndex = 16;
            btnBranch.Text = "Manage Branches";
            btnBranch.UseVisualStyleBackColor = true;
            btnBranch.Click += btnBranch_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLogs);
            groupBox3.Location = new Point(53, 531);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(272, 63);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Misc.";
            // 
            // Form_AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 671);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form_AdminPanel";
            Text = "IMS Developer's Panel";
            FormClosed += Form_AdminPanel_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
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
        private Button btnMasterList;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnDeliveries;
        private Button btnBranch;
        private Button btnResupply;
        private Button btnRealReSupply;
    }
}