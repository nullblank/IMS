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
            SuspendLayout();
            // 
            // btnLogs
            // 
            btnLogs.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnLogs.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogs.Location = new Point(58, 99);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(259, 30);
            btnLogs.TabIndex = 0;
            btnLogs.Text = "View Logs";
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.Location = new Point(58, 169);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(259, 30);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            btnUsers.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnUsers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUsers.Location = new Point(58, 134);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(259, 30);
            btnUsers.TabIndex = 2;
            btnUsers.Text = "Manage Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // Form_AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 310);
            Controls.Add(btnUsers);
            Controls.Add(btnLogs);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form_AdminPanel";
            Text = "IMS Admin Panel";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogs;
        private Button btnLogout;
        private Button btnUsers;
    }
}