using IMS.DBHandler;
using IMS.src;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.forms
{
    public partial class Form_ReferenceContainer : Form
    {
        string _table;
        string _prefix;
        public Form_ReferenceContainer(DatabaseHandler handler, SessionHandler session, string table)
        {
            InitializeComponent();
            InitContainer(table, session, handler);
            _table = table;
            _prefix = table.Substring(table.LastIndexOf("_") + 1);
            //This will get the last index of a string, for example "IMS_RFN_COL" -> "COL". This will be used for dynamic table controls and etc. 
        }
        private void InitContainer(string table, SessionHandler session, DatabaseHandler handler)
        {
            DataTable results = new DataTable();
            string query = $"SELECT * FROM {table}";
            results = handler.ExecuteQuery(query);
            dgvContainer.DataSource = results;
            this.Text = $"Now Viewing: {table}";
        }

        private void dgvContainer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvContainer.Rows[e.RowIndex];
                txtCode.Text = selectedRow.Cells[1].Value.ToString();
                txtDescription.Text = selectedRow.Cells[2].Value.ToString();
                if (txtCode.Text == "")
                {
                    btnUpdate.Enabled = false;
                }
                else
                {
                    btnUpdate.Enabled = true;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            togglestate("New");
        }

        private void togglestate(string state)
        {
            switch (state)
            {
                case "New":
                    dgvContainer.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnNew.Enabled = false;
                    txtCode.ReadOnly = false;
                    txtDescription.ReadOnly = false;
                    txtCode.Clear();
                    txtDescription.Clear();
                    break;
                case "Update":
                    dgvContainer.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnNew.Enabled = false;
                    txtCode.ReadOnly = false;
                    txtDescription.ReadOnly = false;
                    break;
                case "Gen":
                    dgvContainer.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnNew.Enabled = true;
                    txtCode.ReadOnly = true;
                    txtDescription.ReadOnly = true;
                    txtCode.Clear();
                    txtDescription.Clear();
                    break;
                default:
                    MessageBox.Show("Unknown State");
                    break;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            togglestate("Update");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            togglestate("Gen");
        }
    }
}
