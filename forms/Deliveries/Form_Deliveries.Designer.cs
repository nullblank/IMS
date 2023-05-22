namespace IMS.forms
{
    partial class Form_Deliveries
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
            dgvDeliveries = new DataGridView();
            groupBox1 = new GroupBox();
            btnAddDelivery = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDeliveries).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDeliveries
            // 
            dgvDeliveries.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDeliveries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeliveries.Location = new Point(6, 26);
            dgvDeliveries.Name = "dgvDeliveries";
            dgvDeliveries.ReadOnly = true;
            dgvDeliveries.RowHeadersWidth = 51;
            dgvDeliveries.RowTemplate.Height = 29;
            dgvDeliveries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeliveries.Size = new Size(1032, 417);
            dgvDeliveries.TabIndex = 0;
            dgvDeliveries.CellClick += dgvDeliveries_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dgvDeliveries);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1044, 449);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Deliveries";
            // 
            // btnAddDelivery
            // 
            btnAddDelivery.Location = new Point(12, 467);
            btnAddDelivery.Name = "btnAddDelivery";
            btnAddDelivery.Size = new Size(194, 62);
            btnAddDelivery.TabIndex = 6;
            btnAddDelivery.Text = "Add Delivery";
            btnAddDelivery.UseVisualStyleBackColor = true;
            btnAddDelivery.Click += button5_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(212, 467);
            button1.Name = "button1";
            button1.Size = new Size(194, 62);
            button1.TabIndex = 7;
            button1.Text = "Remove Delivery";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form_Deliveries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 541);
            Controls.Add(button1);
            Controls.Add(btnAddDelivery);
            Controls.Add(groupBox1);
            Name = "Form_Deliveries";
            Text = "Form_Deliveries";
            ((System.ComponentModel.ISupportInitialize)dgvDeliveries).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDeliveries;
        private GroupBox groupBox1;
        private System.CodeDom.CodeTypeReference btnAdd;
        private System.CodeDom.CodeTypeReference btnRemove;
        private Button btnAddDelivery;
        private Button button1;
    }
}