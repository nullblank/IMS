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
        DatabaseHandler _handler;
        SessionHandler _session;
        string _table;
        string _prefix;
        string _state;
        string _oldEntry;
        public Form_ReferenceContainer(DatabaseHandler handler, SessionHandler session, string table)
        {
            InitializeComponent();
            InitContainer(table, session, handler);
            _table = table;
            _prefix = table.Substring(table.LastIndexOf("_") + 1);
            _session = session;
            _handler = handler;
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
                _oldEntry = selectedRow.Cells[2].Value.ToString();
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
                    _state = state;
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
                    _state = state;
                    dgvContainer.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnNew.Enabled = false;
                    txtCode.ReadOnly = true;
                    txtDescription.ReadOnly = false;
                    break;
                case "Gen":
                    _state = state;
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
            if (_state == "New")
            {//Add more controls to this and a dialogue Box for confirmation
                Reference reference = new Reference(_handler, _session);
                if (reference.AddEntry(txtCode, txtDescription, _table, _prefix))
                {
                    Audit audit = new Audit(_handler);
                    audit.LogUserAction($"New Entry at Table: {_table}, Entry: {txtDescription.Text}", _session);
                    InitContainer(_table, _session, _handler);
                }
                togglestate("Gen");
            }
            else if (_state == "Update")
            {
                Reference reference = new Reference(_handler, _session);
                if (reference.UpdateEntry(txtCode, txtDescription, _table, _prefix))
                {
                    Audit audit = new Audit(_handler);
                    audit.LogUserAction($"Updated Entry at Table: {_table}, New Entry: {txtDescription.Text}, Old Entry: {_oldEntry}", _session);
                    InitContainer(_table, _session, _handler);
                }
                togglestate("Gen");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            togglestate("Gen");
        }
    }
}
