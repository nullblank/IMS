namespace IMS.forms.requests_resupply
{
    partial class Form_Satisfy
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
            groupBox4 = new GroupBox();
            lvItems = new ListView();
            groupBox1 = new GroupBox();
            lvSend = new ListView();
            groupBox2 = new GroupBox();
            dgvStockpile = new DataGridView();
            button1 = new Button();
            groupBox3 = new GroupBox();
            button3 = new Button();
            groupBox5 = new GroupBox();
            txtAmount = new TextBox();
            label2 = new Label();
            txtSelected = new TextBox();
            btnSend = new Button();
            label1 = new Label();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockpile).BeginInit();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lvItems);
            groupBox4.Location = new Point(12, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(378, 338);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Items requested";
            // 
            // lvItems
            // 
            lvItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvItems.FullRowSelect = true;
            lvItems.Location = new Point(6, 26);
            lvItems.Name = "lvItems";
            lvItems.Size = new Size(366, 306);
            lvItems.TabIndex = 0;
            lvItems.UseCompatibleStateImageBehavior = false;
            lvItems.View = View.Details;
            lvItems.SelectedIndexChanged += lvItems_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lvSend);
            groupBox1.Location = new Point(396, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 338);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Items to send";
            // 
            // lvSend
            // 
            lvSend.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvSend.FullRowSelect = true;
            lvSend.Location = new Point(6, 26);
            lvSend.Name = "lvSend";
            lvSend.Size = new Size(366, 306);
            lvSend.TabIndex = 0;
            lvSend.UseCompatibleStateImageBehavior = false;
            lvSend.View = View.Details;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvStockpile);
            groupBox2.Location = new Point(12, 350);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(762, 278);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Stockpile";
            // 
            // dgvStockpile
            // 
            dgvStockpile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStockpile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockpile.Location = new Point(6, 26);
            dgvStockpile.Name = "dgvStockpile";
            dgvStockpile.ReadOnly = true;
            dgvStockpile.RowHeadersWidth = 51;
            dgvStockpile.RowTemplate.Height = 29;
            dgvStockpile.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStockpile.Size = new Size(750, 246);
            dgvStockpile.TabIndex = 0;
            dgvStockpile.CellClick += dgvStockpile_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(6, 26);
            button1.Name = "button1";
            button1.Size = new Size(228, 29);
            button1.TabIndex = 1;
            button1.Text = "Remove Selected";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(780, 48);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(240, 200);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Delivery Controls";
            // 
            // button3
            // 
            button3.Location = new Point(6, 130);
            button3.Name = "button3";
            button3.Size = new Size(228, 64);
            button3.TabIndex = 3;
            button3.Text = "Finalize Delivery";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtAmount);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(txtSelected);
            groupBox5.Controls.Add(btnSend);
            groupBox5.Controls.Add(label1);
            groupBox5.Location = new Point(780, 388);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(240, 130);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Stockpile Controls";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(94, 59);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(140, 27);
            txtAmount.TabIndex = 8;
            txtAmount.KeyDown += txtAmount_KeyDown;
            txtAmount.KeyPress += txtAmount_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 62);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 7;
            label2.Text = "Quantity:";
            // 
            // txtSelected
            // 
            txtSelected.Location = new Point(94, 26);
            txtSelected.Name = "txtSelected";
            txtSelected.ReadOnly = true;
            txtSelected.Size = new Size(140, 27);
            txtSelected.TabIndex = 6;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(6, 92);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(228, 29);
            btnSend.TabIndex = 4;
            btnSend.Text = "Add Item to send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 5;
            label1.Text = "Selected #:";
            // 
            // Form_Satisfy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 635);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Name = "Form_Satisfy";
            Text = "Form_Satisfy";
            groupBox4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStockpile).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private ListView lvItems;
        private GroupBox groupBox1;
        private ListView lvSend;
        private GroupBox groupBox2;
        private DataGridView dgvStockpile;
        private Button button1;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private Button button3;
        private TextBox txtSelected;
        private Label label1;
        private Button btnSend;
        private TextBox txtAmount;
        private Label label2;
    }
}