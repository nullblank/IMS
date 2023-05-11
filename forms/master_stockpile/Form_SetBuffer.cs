﻿using IMS.DBHandler;
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
        int _index;
        public Form_SetBuffer(DataGridView grid, DataGridViewCellEventArgs e, DatabaseHandler handler, SessionHandler session)
        {
            InitializeComponent();
            _grid = grid;
            DataGridViewRow row = _grid.Rows[e.RowIndex];
            _index = Int32.Parse(row.Cells["SITE_IDX"].Value.ToString());
            _handler = handler;
            _session = session;
        }

        private void txtBuffVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Updating Index: {_index}");
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
            this.Hide();
        }
    }
}
