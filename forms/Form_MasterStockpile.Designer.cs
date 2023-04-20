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
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStockpile).BeginInit();
            SuspendLayout();
            // 
            // dgvStockpile
            // 
            dgvStockpile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockpile.Location = new Point(12, 45);
            dgvStockpile.Name = "dgvStockpile";
            dgvStockpile.RowHeadersWidth = 51;
            dgvStockpile.RowTemplate.Height = 29;
            dgvStockpile.Size = new Size(934, 437);
            dgvStockpile.TabIndex = 0;
            // 
            // btnDeliveries
            // 
            btnDeliveries.Location = new Point(576, 488);
            btnDeliveries.Name = "btnDeliveries";
            btnDeliveries.Size = new Size(156, 64);
            btnDeliveries.TabIndex = 1;
            btnDeliveries.Text = "Deliveries Logs";
            btnDeliveries.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(738, 488);
            button1.Name = "button1";
            button1.Size = new Size(208, 29);
            button1.TabIndex = 2;
            button1.Text = "Supply Request Logs";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(738, 523);
            button2.Name = "button2";
            button2.Size = new Size(208, 29);
            button2.TabIndex = 3;
            button2.Text = "Supply Delivered Logs";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 488);
            button3.Name = "button3";
            button3.Size = new Size(208, 29);
            button3.TabIndex = 4;
            button3.Text = "Supply Request Logs";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 523);
            button4.Name = "button4";
            button4.Size = new Size(208, 29);
            button4.TabIndex = 5;
            button4.Text = "Supply Request Logs";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 27);
            textBox1.TabIndex = 6;
            // 
            // button5
            // 
            button5.Location = new Point(314, 11);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 7;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(738, 10);
            button6.Name = "button6";
            button6.Size = new Size(208, 29);
            button6.TabIndex = 8;
            button6.Text = "View Item Delivery Logs";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form_MasterStockpile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 612);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnDeliveries);
            Controls.Add(dgvStockpile);
            Name = "Form_MasterStockpile";
            Text = "Form_MasterStockpile";
            ((System.ComponentModel.ISupportInitialize)dgvStockpile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStockpile;
        private Button btnDeliveries;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Button button5;
        private Button button6;
    }
}