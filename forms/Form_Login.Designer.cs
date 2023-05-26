namespace IMS
{
    partial class Form_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            gb1 = new GroupBox();
            gb1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(95, 104);
            button1.Name = "button1";
            button1.Size = new Size(201, 29);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(19, 174);
            button2.Name = "button2";
            button2.Size = new Size(277, 29);
            button2.TabIndex = 1;
            button2.Text = "Test Connection";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(95, 38);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(201, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(95, 71);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(201, 27);
            txtPassword.TabIndex = 3;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 41);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 74);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // gb1
            // 
            gb1.Controls.Add(txtUsername);
            gb1.Controls.Add(button2);
            gb1.Controls.Add(label2);
            gb1.Controls.Add(button1);
            gb1.Controls.Add(label1);
            gb1.Controls.Add(txtPassword);
            gb1.Location = new Point(12, 12);
            gb1.Name = "gb1";
            gb1.Size = new Size(312, 209);
            gb1.TabIndex = 6;
            gb1.TabStop = false;
            gb1.Text = "vX.X.X.X";
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 233);
            Controls.Add(gb1);
            Name = "Form_Login";
            Text = "Login IMS";
            FormClosed += Form_Login_FormClosed;
            Load += Form_Login_Load;
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private GroupBox gb1;
    }
}