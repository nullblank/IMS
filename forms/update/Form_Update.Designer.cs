namespace IMS.forms.update
{
    partial class Form_Update
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
            progressBar = new ProgressBar();
            lblAction = new Label();
            lblVAction = new Label();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 32);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(601, 29);
            progressBar.TabIndex = 0;
            // 
            // lblAction
            // 
            lblAction.AutoSize = true;
            lblAction.Location = new Point(12, 9);
            lblAction.Name = "lblAction";
            lblAction.Size = new Size(152, 20);
            lblAction.TabIndex = 1;
            lblAction.Text = "Checking for update...";
            // 
            // lblVAction
            // 
            lblVAction.AutoSize = true;
            lblVAction.Location = new Point(12, 64);
            lblVAction.Name = "lblVAction";
            lblVAction.Size = new Size(18, 20);
            lblVAction.TabIndex = 2;
            lblVAction.Text = "...";
            // 
            // Form_Update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 100);
            Controls.Add(lblVAction);
            Controls.Add(lblAction);
            Controls.Add(progressBar);
            Name = "Form_Update";
            Text = "Form_Update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar;
        private Label lblAction;
        private Label lblVAction;
    }
}