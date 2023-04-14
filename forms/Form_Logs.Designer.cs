namespace IMS.forms
{
    partial class Form_Logs
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
            dgvLogs = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            SuspendLayout();
            // 
            // dgvLogs
            // 
            dgvLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Location = new Point(12, 12);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.RowHeadersWidth = 51;
            dgvLogs.RowTemplate.Height = 29;
            dgvLogs.RowTemplate.ReadOnly = true;
            dgvLogs.Size = new Size(815, 502);
            dgvLogs.TabIndex = 0;
            // 
            // Form_Logs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 526);
            Controls.Add(dgvLogs);
            Name = "Form_Logs";
            Text = "Form_Logs";
            Load += Form_Logs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLogs;
    }
}