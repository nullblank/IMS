namespace IMS.forms.requests_resupply
{
    partial class Form_Requests
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
            label1 = new Label();
            lblRole = new Label();
            dgvRequests = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            lblUser = new Label();
            lblOffice = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnResupply = new Button();
            btnCancelResupply = new Button();
            groupBox4 = new GroupBox();
            lvRequestItems = new ListView();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 67);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Office:";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(125, 99);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(117, 20);
            lblRole.TabIndex = 1;
            lblRole.Text = "#PLACEHOLDER";
            // 
            // dgvRequests
            // 
            dgvRequests.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.Location = new Point(6, 26);
            dgvRequests.Name = "dgvRequests";
            dgvRequests.RowHeadersWidth = 51;
            dgvRequests.RowTemplate.Height = 29;
            dgvRequests.Size = new Size(852, 282);
            dgvRequests.TabIndex = 2;
            dgvRequests.CellClick += dgvRequests_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dgvRequests);
            groupBox1.Location = new Point(12, 314);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(864, 314);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Requests";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(lblUser);
            groupBox2.Controls.Add(lblRole);
            groupBox2.Controls.Add(lblOffice);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(574, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(302, 145);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 99);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 6;
            label3.Text = "Current Role:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(125, 37);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(117, 20);
            lblUser.TabIndex = 7;
            lblUser.Text = "#PLACEHOLDER";
            // 
            // lblOffice
            // 
            lblOffice.AutoSize = true;
            lblOffice.Location = new Point(125, 67);
            lblOffice.Name = "lblOffice";
            lblOffice.Size = new Size(117, 20);
            lblOffice.TabIndex = 6;
            lblOffice.Text = "#PLACEHOLDER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 37);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 5;
            label2.Text = "User:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnResupply);
            groupBox3.Controls.Add(btnCancelResupply);
            groupBox3.Location = new Point(574, 163);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(158, 145);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Controls";
            // 
            // btnResupply
            // 
            btnResupply.Location = new Point(6, 26);
            btnResupply.Name = "btnResupply";
            btnResupply.Size = new Size(145, 29);
            btnResupply.TabIndex = 6;
            btnResupply.Text = "Request Resupply";
            btnResupply.UseVisualStyleBackColor = true;
            btnResupply.Click += btnResupply_Click;
            // 
            // btnCancelResupply
            // 
            btnCancelResupply.Location = new Point(6, 61);
            btnCancelResupply.Name = "btnCancelResupply";
            btnCancelResupply.Size = new Size(145, 29);
            btnCancelResupply.TabIndex = 7;
            btnCancelResupply.Text = "Cancel Resupply";
            btnCancelResupply.UseVisualStyleBackColor = true;
            btnCancelResupply.Click += btnCancelResupply_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lvRequestItems);
            groupBox4.Location = new Point(12, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(556, 296);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Items Requested";
            // 
            // lvRequestItems
            // 
            lvRequestItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvRequestItems.Location = new Point(6, 26);
            lvRequestItems.Name = "lvRequestItems";
            lvRequestItems.Size = new Size(544, 264);
            lvRequestItems.TabIndex = 0;
            lvRequestItems.UseCompatibleStateImageBehavior = false;
            lvRequestItems.View = View.Details;
            // 
            // Form_Requests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 640);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form_Requests";
            Text = "Requests";
            Load += Requests_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblRole;
        private DataGridView dgvRequests;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label lblUser;
        private Label lblOffice;
        private Label label2;
        private GroupBox groupBox3;
        private Button btnResupply;
        private Button btnCancelResupply;
        private GroupBox groupBox4;
        private ListView lvRequestItems;
    }
}