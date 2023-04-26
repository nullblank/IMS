namespace IMS.forms
{
    partial class Form_Users
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
            components = new System.ComponentModel.Container();
            dgvUsers = new DataGridView();
            btnSave = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtID = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cbPerms = new ComboBox();
            cbOffice = new ComboBox();
            btnCancel = new Button();
            label6 = new Label();
            cbActive = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(12, 191);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowTemplate.Height = 29;
            dgvUsers.Size = new Size(1093, 406);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(16, 128);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(185, 47);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(398, 128);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(185, 47);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(589, 128);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(185, 47);
            btnNew.TabIndex = 4;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 5;
            label1.Text = "User ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 48);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 81);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 14);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 8;
            label4.Text = "Permissions";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(330, 48);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 9;
            label5.Text = "Office";
            // 
            // txtID
            // 
            txtID.Location = new Point(96, 12);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(151, 27);
            txtID.TabIndex = 10;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(96, 45);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(151, 27);
            txtUsername.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(96, 78);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(151, 27);
            txtPassword.TabIndex = 12;
            // 
            // cbPerms
            // 
            cbPerms.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPerms.Enabled = false;
            cbPerms.FormattingEnabled = true;
            cbPerms.Location = new Point(384, 11);
            cbPerms.Name = "cbPerms";
            cbPerms.Size = new Size(151, 28);
            cbPerms.TabIndex = 15;
            // 
            // cbOffice
            // 
            cbOffice.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOffice.Enabled = false;
            cbOffice.FormattingEnabled = true;
            cbOffice.Location = new Point(384, 45);
            cbOffice.Name = "cbOffice";
            cbOffice.Size = new Size(151, 28);
            cbOffice.TabIndex = 16;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(207, 128);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(185, 47);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 82);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 18;
            label6.Text = "Enable Account";
            // 
            // cbActive
            // 
            cbActive.DropDownStyle = ComboBoxStyle.DropDownList;
            cbActive.Enabled = false;
            cbActive.FormattingEnabled = true;
            cbActive.Items.AddRange(new object[] { "No", "Yes" });
            cbActive.Location = new Point(385, 79);
            cbActive.Name = "cbActive";
            cbActive.Size = new Size(151, 28);
            cbActive.TabIndex = 19;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form_Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 609);
            Controls.Add(cbActive);
            Controls.Add(label6);
            Controls.Add(btnCancel);
            Controls.Add(cbOffice);
            Controls.Add(cbPerms);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNew);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dgvUsers);
            Name = "Form_Users";
            Text = "User Management";
            Load += Form_Users_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnNew;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtID;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cbPerms;
        private ComboBox cbOffice;
        private Button btnCancel;
        private Label label6;
        private ComboBox cbActive;
        private ErrorProvider errorProvider1;
    }
}