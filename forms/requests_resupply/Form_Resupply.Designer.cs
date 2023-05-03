﻿namespace IMS.forms.requests_resupply
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
            label4 = new Label();
            cbItem = new ComboBox();
            label3 = new Label();
            cbSCategory = new ComboBox();
            label2 = new Label();
            cbCategory = new ComboBox();
            label1 = new Label();
            btnCancel = new Button();
            btnAdd = new Button();
            lvItems = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnRequest = new Button();
            btnRemove = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbItem);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbSCategory);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbCategory);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 222);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(757, 98);
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
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(554, 29);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 7;
            label4.Text = "Amount";
            // 
            // cbItem
            // 
            cbItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbItem.FormattingEnabled = true;
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
            label3.Size = new Size(83, 20);
            label3.TabIndex = 5;
            label3.Text = "Item Name";
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
            // btnCancel
            // 
            btnCancel.Location = new Point(675, 326);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 38);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(475, 326);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 38);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnSave_Click;
            // 
            // lvItems
            // 
            lvItems.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvItems.Location = new Point(12, 12);
            lvItems.Name = "lvItems";
            lvItems.Size = new Size(757, 204);
            lvItems.TabIndex = 8;
            lvItems.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Order ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Order Item Name";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Order Amount";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Order Cost";
            // 
            // btnRequest
            // 
            btnRequest.Location = new Point(12, 326);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(94, 38);
            btnRequest.TabIndex = 9;
            btnRequest.Text = "Request";
            btnRequest.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(575, 325);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 38);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // Form_Resupply
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 375);
            Controls.Add(btnRemove);
            Controls.Add(btnRequest);
            Controls.Add(lvItems);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(groupBox1);
            Name = "Form_Resupply";
            Text = "Form_Resupply";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button btnCancel;
        private Button btnAdd;
        private ListView lvItems;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnRequest;
        private Button btnRemove;
    }
}