namespace IMS.forms.requests_resupply
{
    partial class Form_Resupply
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
            txtAmount = new TextBox();
            btnRemove = new Button();
            label4 = new Label();
            cbItem = new ComboBox();
            label3 = new Label();
            cbSCategory = new ComboBox();
            btnAdd = new Button();
            label2 = new Label();
            cbCategory = new ComboBox();
            label1 = new Label();
            txtPurpose = new TextBox();
            lvItems = new ListView();
            btnRequest = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbItem);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbSCategory);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbCategory);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 222);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(757, 117);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item Details";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(622, 27);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(128, 27);
            txtAmount.TabIndex = 4;
            txtAmount.KeyPress += txtAmount_KeyPress;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(646, 63);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 38);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(545, 29);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 7;
            label4.Text = "Quantity*";
            // 
            // cbItem
            // 
            cbItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbItem.FormattingEnabled = true;
            cbItem.Items.AddRange(new object[] { "" });
            cbItem.Location = new Point(101, 60);
            cbItem.Name = "cbItem";
            cbItem.Size = new Size(424, 28);
            cbItem.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 63);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 5;
            label3.Text = "Item Name*";
            // 
            // cbSCategory
            // 
            cbSCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSCategory.FormattingEnabled = true;
            cbSCategory.Items.AddRange(new object[] { "" });
            cbSCategory.Location = new Point(374, 26);
            cbSCategory.Name = "cbSCategory";
            cbSCategory.Size = new Size(151, 28);
            cbSCategory.TabIndex = 2;
            cbSCategory.SelectedIndexChanged += cbSCategory_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(546, 63);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 38);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 29);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 3;
            label2.Text = "Subcategory";
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "" });
            cbCategory.Location = new Point(101, 26);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(151, 28);
            cbCategory.TabIndex = 0;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 29);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Category";
            // 
            // txtPurpose
            // 
            txtPurpose.Location = new Point(6, 26);
            txtPurpose.Name = "txtPurpose";
            txtPurpose.Size = new Size(445, 27);
            txtPurpose.TabIndex = 9;
            // 
            // lvItems
            // 
            lvItems.FullRowSelect = true;
            lvItems.Location = new Point(12, 12);
            lvItems.Name = "lvItems";
            lvItems.Size = new Size(757, 204);
            lvItems.TabIndex = 8;
            lvItems.UseCompatibleStateImageBehavior = false;
            // 
            // btnRequest
            // 
            btnRequest.Location = new Point(475, 345);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(294, 64);
            btnRequest.TabIndex = 9;
            btnRequest.Text = "Finalize Request";
            btnRequest.UseVisualStyleBackColor = true;
            btnRequest.Click += btnRequest_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPurpose);
            groupBox2.Location = new Point(12, 345);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(457, 64);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Purpose*";
            // 
            // Form_Resupply
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 422);
            Controls.Add(groupBox2);
            Controls.Add(btnRequest);
            Controls.Add(lvItems);
            Controls.Add(groupBox1);
            Name = "Form_Resupply";
            Text = "Form_Resupply";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtAmount;
        private Label label4;
        private ComboBox cbItem;
        private Label label3;
        private ComboBox cbSCategory;
        private Label label2;
        private ComboBox cbCategory;
        private Label label1;
        private Button btnAdd;
        private ListView lvItems;
        private Button btnRequest;
        private Button btnRemove;
        private TextBox txtPurpose;
        private GroupBox groupBox2;
    }
}