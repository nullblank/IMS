namespace IMS.forms.report
{
    partial class Form_Reports_View
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
            dgvView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvView).BeginInit();
            SuspendLayout();
            // 
            // dgvView
            // 
            dgvView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvView.Location = new Point(12, 12);
            dgvView.Name = "dgvView";
            dgvView.RowHeadersWidth = 51;
            dgvView.RowTemplate.Height = 29;
            dgvView.Size = new Size(1087, 653);
            dgvView.TabIndex = 0;
            // 
            // Form_Reports_View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 677);
            Controls.Add(dgvView);
            Name = "Form_Reports_View";
            Text = "Form_Reports_View";
            ((System.ComponentModel.ISupportInitialize)dgvView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvView;
    }
}