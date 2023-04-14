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
            SuspendLayout();
            // 
            // btnLogs
            // 
            btnLogs.Location = new Point(12, 409);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(94, 29);
            btnLogs.TabIndex = 0;
            btnLogs.Text = "View Logs";
            btnLogs.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(694, 409);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // Form_AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnLogs);
            Name = "Form_AdminPanel";
            Text = "IMS Admin Panel";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogs;
        private Button btnLogout;
    }
}