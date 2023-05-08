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
            btnDelivered = new Button();
            btnProcessing = new Button();
            btnDenied = new Button();
            btnPending = new Button();
            groupBox3 = new GroupBox();
            txtUser = new TextBox();
            txtOffice = new TextBox();
            txtPurpose = new TextBox();
            txtRequestNumber = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox4 = new GroupBox();
            lvItems = new ListView();
            groupBox5 = new GroupBox();
            btnSatisfy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
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
            dgvRequests.Size = new Size(578, 490);
            dgvRequests.TabIndex = 0;
            dgvRequests.CellClick += dgvRequests_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvRequests);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(590, 522);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Requests";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDelivered);
            groupBox2.Controls.Add(btnProcessing);
            groupBox2.Controls.Add(btnDenied);
            groupBox2.Controls.Add(btnPending);
            groupBox2.Location = new Point(992, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(195, 178);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Status Control";
            // 
            // btnDelivered
            // 
            btnDelivered.Location = new Point(6, 131);
            btnDelivered.Name = "btnDelivered";
            btnDelivered.Size = new Size(183, 29);
            btnDelivered.TabIndex = 3;
            btnDelivered.Text = "Delivered";
            btnDelivered.UseVisualStyleBackColor = true;
            btnDelivered.Click += btnDelivered_Click;
            // 
            // btnProcessing
            // 
            btnProcessing.Location = new Point(6, 96);
            btnProcessing.Name = "btnProcessing";
            btnProcessing.Size = new Size(183, 29);
            btnProcessing.TabIndex = 3;
            btnProcessing.Text = "Processing";
            btnProcessing.UseVisualStyleBackColor = true;
            btnProcessing.Click += btnProcessing_Click;
            // 
            // btnDenied
            // 
            btnDenied.Location = new Point(6, 61);
            btnDenied.Name = "btnDenied";
            btnDenied.Size = new Size(183, 29);
            btnDenied.TabIndex = 3;
            btnDenied.Text = "Denied";
            btnDenied.UseVisualStyleBackColor = true;
            btnDenied.Click += btnDenied_Click;
            // 
            // btnPending
            // 
            btnPending.Location = new Point(6, 26);
            btnPending.Name = "btnPending";
            btnPending.Size = new Size(183, 29);
            btnPending.TabIndex = 3;
            btnPending.Text = "Pending";
            btnPending.UseVisualStyleBackColor = true;
            btnPending.Click += btnPending_Click;
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
            groupBox3.Location = new Point(608, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(378, 178);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Information";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(95, 125);
            txtUser.Name = "txtUser";
            txtUser.ReadOnly = true;
            txtUser.Size = new Size(192, 27);
            txtUser.TabIndex = 13;
            // 
            // txtOffice
            // 
            txtOffice.Location = new Point(95, 92);
            txtOffice.Name = "txtOffice";
            txtOffice.ReadOnly = true;
            txtOffice.Size = new Size(192, 27);
            txtOffice.TabIndex = 12;
            // 
            // txtPurpose
            // 
            txtPurpose.Location = new Point(95, 59);
            txtPurpose.Name = "txtPurpose";
            txtPurpose.ReadOnly = true;
            txtPurpose.Size = new Size(192, 27);
            txtPurpose.TabIndex = 11;
            // 
            // txtRequestNumber
            // 
            txtRequestNumber.Location = new Point(95, 26);
            txtRequestNumber.Name = "txtRequestNumber";
            txtRequestNumber.ReadOnly = true;
            txtRequestNumber.Size = new Size(192, 27);
            txtRequestNumber.TabIndex = 10;
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
            // groupBox4
            // 
            groupBox4.Controls.Add(lvItems);
            groupBox4.Location = new Point(608, 196);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(378, 338);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Items";
            // 
            // lvItems
            // 
            lvItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvItems.Location = new Point(6, 26);
            lvItems.Name = "lvItems";
            lvItems.Size = new Size(366, 306);
            lvItems.TabIndex = 0;
            lvItems.UseCompatibleStateImageBehavior = false;
            lvItems.View = View.Details;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnSatisfy);
            groupBox5.Location = new Point(998, 196);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(189, 74);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Status Control";
            // 
            // btnSatisfy
            // 
            btnSatisfy.Location = new Point(6, 26);
            btnSatisfy.Name = "btnSatisfy";
            btnSatisfy.Size = new Size(177, 29);
            btnSatisfy.TabIndex = 3;
            btnSatisfy.Text = "Satisfy Request";
            btnSatisfy.UseVisualStyleBackColor = true;
            btnSatisfy.Click += btnSatisfy_Click;
            // 
            // Form_Outbound
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 546);
            Controls.Add(groupBox5);
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
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRequests;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnDelivered;
        private Button btnProcessing;
        private Button btnDenied;
        private Button btnPending;
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
        private GroupBox groupBox5;
        private Button btnSatisfy;
    }
}