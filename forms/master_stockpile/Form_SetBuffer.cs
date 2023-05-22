using IMS.DBHandler;
using IMS.src;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.forms.master_stockpile
{
    public partial class Form_SetBuffer : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        DataGridView _grid;
        Form_MasterStockpile _form;
        int _index;
        public Form_SetBuffer(DataGridView grid, DataGridViewCellEventArgs e, DatabaseHandler handler, SessionHandler session, Form_MasterStockpile form)
        {
            InitializeComponent();
            _grid = grid;
            DataGridViewRow row = _grid.Rows[e.RowIndex];
            if (!string.IsNullOrEmpty(row.Cells[0].Value.ToString()) || row.Cells[0].Value.ToString() != "")
            {
                _index = Int32.Parse(row.Cells[0].Value.ToString());
            }
            _handler = handler;
            _session = session;
            _form = form;
        }

        private void txtBuffVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int buffVal;
            if (int.TryParse(txtBuffVal.Text, out buffVal))
            {
                string query = $"UPDATE IMS_SITE SET SITE_BV = {buffVal} WHERE SITE_IDX = {_index}";
                _handler.ExecuteNonQuery(query);
            }
            else
            {
                MessageBox.Show("ERROR: INPUT NOT VALID.");
            }
            _form.InitData(_session, _handler);
            this.Hide();
        }
    }
}
