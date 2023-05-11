namespace IMS.forms.master_stockpile
{
    partial class Form_SetBuffer
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
            txtBuffVal = new TextBox();
            label1 = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtBuffVal
            // 
            txtBuffVal.Location = new Point(186, 12);
            txtBuffVal.Name = "txtBuffVal";
            txtBuffVal.Size = new Size(125, 27);
            txtBuffVal.TabIndex = 0;
            txtBuffVal.KeyPress += txtBuffVal_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter New Buffer Value:";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(317, 11);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(112, 29);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(435, 11);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // Form_SetBuffer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 52);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Controls.Add(txtBuffVal);
            Name = "Form_SetBuffer";
            Text = "Form_SetBuffer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuffVal;
        private Label label1;
        private Button btnConfirm;
        private Button btnCancel;
    }
}