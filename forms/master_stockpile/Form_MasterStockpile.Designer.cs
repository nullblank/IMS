namespace IMS.forms
{
    partial class Form_MasterStockpile
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
            dgvStockpile = new DataGridView();
            btnDeliveries = new Button();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            groupBox1 = new GroupBox();
            btnBuff = new Button();
            btnUpdate = new Button();
            btnAddItem = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStockpile).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStockpile
            // 
            dgvStockpile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvStockpile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockpile.Location = new Point(18, 45);
            dgvStockpile.Name = "dgvStockpile";
            dgvStockpile.RowHeadersWidth = 51;
            dgvStockpile.RowTemplate.Height = 29;
            dgvStockpile.Size = new Size(1050, 437);
            dgvStockpile.TabIndex = 0;
            dgvStockpile.CellClick += dgvStockpile_CellClick;
            dgvStockpile.CellFormatting += dgvStockpile_CellFormatting;
            dgvStockpile.DataBindingComplete += dgvStockpile_DataBindingComplete;
            // 
            // btnDeliveries
            // 
            btnDeliveries.Location = new Point(6, 26);
            btnDeliveries.Name = "btnDeliveries";
            btnDeliveries.Size = new Size(156, 64);
            btnDeliveries.TabIndex = 1;
            btnDeliveries.Text = "Delivery Logs";
            btnDeliveries.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(168, 26);
            button1.Name = "button1";
            button1.Size = new Size(208, 29);
            button1.TabIndex = 2;
            button1.Text = "Supply Request Logs";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(168, 61);
            button2.Name = "button2";
            button2.Size = new Size(208, 29);
            button2.TabIndex = 3;
            button2.Text = "Supply Delivered Logs";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(111, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 27);
            textBox1.TabIndex = 6;
            // 
            // button5
            // 
            button5.Location = new Point(413, 11);
            button5.Name = "button5";
            button5.Size = new Size(122, 29);
            button5.TabIndex = 7;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Enabled = false;
            button6.Location = new Point(167, 26);
            button6.Name = "button6";
            button6.Size = new Size(208, 29);
            button6.TabIndex = 8;
            button6.Text = "View Item Delivery Logs";
            button6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuff);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAddItem);
            groupBox1.Controls.Add(button6);
            groupBox1.Location = new Point(12, 488);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 97);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item";
            // 
            // btnBuff
            // 
            btnBuff.Enabled = false;
            btnBuff.Location = new Point(167, 61);
            btnBuff.Name = "btnBuff";
            btnBuff.Size = new Size(208, 29);
            btnBuff.TabIndex = 11;
            btnBuff.Text = "Update Buffer Value";
            btnBuff.UseVisualStyleBackColor = true;
            btnBuff.Click += btnBuff_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(6, 61);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(155, 29);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update Item";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(6, 26);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(155, 29);
            btnAddItem.TabIndex = 9;
            btnAddItem.Text = "Add New Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(btnDeliveries);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(400, 488);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(381, 97);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Deliveries and Requests";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 15);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 11;
            label1.Text = "Item Name:";
            // 
            // Form_MasterStockpile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 594);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(dgvStockpile);
            Name = "Form_MasterStockpile";
            Text = "Form_MasterStockpile";
            ((System.ComponentModel.ISupportInitialize)dgvStockpile).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStockpile;
        private Button btnDeliveries;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button button5;
        private Button button6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnUpdate;
        private Button btnAddItem;
        private Label label1;
        private Button btnBuff;
    }
}