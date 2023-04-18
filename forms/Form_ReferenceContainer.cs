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
        }

        private void dgvContainer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvContainer.Rows[e.RowIndex];
                txtCode.Text = selectedRow.Cells[0].Value.ToString();
                txtDescription.Text = selectedRow.Cells[0].Value.ToString();
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
    }
}
