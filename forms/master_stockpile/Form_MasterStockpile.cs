﻿using IMS.DBHandler;
using IMS.forms.master_stockpile;
using IMS.src;
using Org.BouncyCastle.Crypto.Fpe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.forms
{
    public partial class Form_MasterStockpile : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        DataGridViewCellEventArgs _e;
        Form_ItemContainer form_itemcontainer;
        Form_SetBuffer form_SetBuffer;
        public Form_MasterStockpile(DatabaseHandler handler, SessionHandler session)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _handler = handler;
            _session = session;
            InitData(session, handler);
            form_itemcontainer = new Form_ItemContainer(_handler, _session, this);
        }

        public void InitData(SessionHandler session, DatabaseHandler handler)
        {
            DataTable results = new DataTable();
            string query = "SELECT" +
                " SITE_IDX AS [Index #]," +
                " SITE_COD AS [Item Code]," +
                " SITE_DES AS [Description]," +
                " SITE_SCAT AS [Category]," +
                " SITE_SCA AS [Subcategory]," +
                " SITE_SUNT AS [Unit]," +
                " SITE_SCOL AS [Color]," +
                " SITE_QOH AS [Quantity in Stock]," +
                " SITE_BV AS [Buffer Value]" +
                " FROM IMS_SITE";
            dgvStockpile.DataSource = handler.ExecuteQuery(query);
            dgvStockpile.Columns["Description"].Width = 500;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Audit audit = new Audit(_handler);
            if (_session.SessionExists())
            {
                audit.LogUserAction("Opened Form_ItemConatiner AddItem.", _session);
                form_itemcontainer.SetState(false);
                form_itemcontainer.ClearData();
                form_itemcontainer.Show();
            }
            else
            {
                MessageBox.Show("WARNING: ILLEGAL ACCESS DETECTED. CLOSING WINDOW!");
                audit.LogAction("Illegal Access on: Form_MasterStockpile -> Form_ItemContainer state: AddItem");
                this.Close();
            }
        }

        private void dgvStockpile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _e = e;
                DataGridViewRow row = dgvStockpile.Rows[e.RowIndex];
                form_itemcontainer.SetData(dgvStockpile, e);

                form_SetBuffer = new Form_SetBuffer(dgvStockpile, e, _handler, _session, this);

                if (row.Cells[1].Value.ToString() == "")
                {
                    btnUpdate.Enabled = false;
                    btnBuff.Enabled = false;
                    btnViewDeliveries.Enabled = false;
                }
                else
                {
                    btnUpdate.Enabled = true;
                    btnBuff.Enabled = true;
                    btnViewDeliveries.Enabled = true;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Audit audit = new Audit(_handler);
            if (_session.SessionExists())
            {
                audit.LogUserAction("Opened Form_ItemConatiner AddItem.", _session);
                //form_itemcontainer.SetData(dgvStockpile, _e);
                form_itemcontainer.SetState(true);//to check if update function
                form_itemcontainer.Show();
            }
            else
            {
                MessageBox.Show("WARNING: ILLEGAL ACCESS DETECTED. CLOSING WINDOW!");
                audit.LogAction("Illegal Access on: Form_MasterStockpile -> Form_ItemContainer state: AddItem");
                this.Close();
            }
        }

        private void dgvStockpile_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btnBuff_Click(object sender, EventArgs e)
        {
            form_SetBuffer.Show();
        }

        private void dgvStockpile_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvStockpile.Rows)
            {
                int value = Convert.ToInt32(row.Cells[7].Value); // replace "YourColumnName" with the name of your column
                int threshold = Convert.ToInt32(row.Cells[8].Value);
                if (value < threshold)
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void btnViewDeliveries_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgvStockpile.Rows[_e.RowIndex];
            int itemcode = Int32.Parse(row.Cells[1].Value.ToString());
            Form_Deliveries form = new Form_Deliveries(_handler, _session);
            form.InitDataQuery(itemcode);
            form.Show();
        }
    }
}
