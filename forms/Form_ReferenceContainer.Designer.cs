namespace IMS.forms
{
    partial class Form_ReferenceContainer
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
            dgvContainer = new DataGridView();
            btnSave = new Button();
            txtCode = new TextBox();
            txtDescription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnUpdate = new Button();
            btnNew = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContainer).BeginInit();
            SuspendLayout();
            // 
            // dgvContainer
            // 
            dgvContainer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContainer.Location = new Point(12, 117);
            dgvContainer.Name = "dgvContainer";
            dgvContainer.RowHeadersWidth = 51;
            dgvContainer.RowTemplate.Height = 29;
            dgvContainer.Size = new Size(650, 304);
            dgvContainer.TabIndex = 0;
            dgvContainer.CellClick += dgvContainer_CellClick;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(12, 52);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(158, 49);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(62, 12);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(125, 27);
            txtCode.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(307, 12);
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 4;
            label1.Text = "Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 15);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 5;
            label2.Text = "Description";
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(176, 52);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(158, 49);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(340, 52);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(158, 49);
            btnNew.TabIndex = 7;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(504, 52);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(158, 49);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form_ReferenceContainer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 436);
            Controls.Add(btnCancel);
            Controls.Add(btnNew);
            Controls.Add(btnUpdate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtCode);
            Controls.Add(btnSave);
            Controls.Add(dgvContainer);
            Name = "Form_ReferenceContainer";
            Text = "#PLACEHOLDER_TITLE";
            ((System.ComponentModel.ISupportInitialize)dgvContainer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvContainer;
        private Button btnSave;
        private TextBox txtCode;
        private TextBox txtDescription;
        private Label label1;
        private Label label2;
        private Button btnUpdate;
        private Button btnNew;
        private Button btnCancel;
    }
}