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
            dgvContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvContainer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContainer.Location = new Point(12, 131);
            dgvContainer.Name = "dgvContainer";
            dgvContainer.ReadOnly = true;
            dgvContainer.RowHeadersWidth = 51;
            dgvContainer.RowTemplate.Height = 29;
            dgvContainer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContainer.Size = new Size(650, 478);
            dgvContainer.TabIndex = 0;
            dgvContainer.CellClick += dgvContainer_CellClick;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(12, 60);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(158, 59);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(62, 20);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(125, 27);
            txtCode.TabIndex = 2;
            txtCode.KeyPress += txtCode_KeyPress;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(307, 20);
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 4;
            label1.Text = "Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 23);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 5;
            label2.Text = "Description";
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(176, 60);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(158, 59);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(340, 60);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(158, 59);
            btnNew.TabIndex = 7;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(504, 60);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(158, 59);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form_ReferenceContainer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 627);
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