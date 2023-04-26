using IMS.DBHandler;
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
        public Form_MasterStockpile(DatabaseHandler handler, SessionHandler session)
        {
            InitializeComponent();
            _handler = handler;
            _session = session;
            InitData(session, handler);
        }

        public void InitData(SessionHandler session, DatabaseHandler handler)
        {
            DataTable results = new DataTable();
            string query = "SELECT * FROM IMS_SITE";
            dgvStockpile.DataSource = handler.ExecuteQuery(query);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Audit audit = new Audit(_handler);
            if (_session.SessionExists())
            {
                Form_ItemContainer form = new Form_ItemContainer(_handler, _session);
                audit.LogUserAction("Opened Form_ItemConatiner AddItem.", _session);
                form.SetState(false);
                form.ClearData();
                form.Show();
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
                Form_ItemContainer form = new Form_ItemContainer(_handler, _session);
                form.SetData(dgvStockpile, e);
                if (row.Cells["SITE_COD"].Value.ToString() == null)
                {
                    btnUpdate.Enabled = false;
                }
                else
                {
                    btnUpdate.Enabled = true;
                }
            }
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Audit audit = new Audit(_handler);
            if (_session.SessionExists())
            {
                Form_ItemContainer form = new Form_ItemContainer(_handler, _session);
                audit.LogUserAction("Opened Form_ItemConatiner AddItem.", _session);
                form.SetData(dgvStockpile, _e);
                form.SetState(true);//to check if update function
                form.Show();
            }
            else
            {
                MessageBox.Show("WARNING: ILLEGAL ACCESS DETECTED. CLOSING WINDOW!");
                audit.LogAction("Illegal Access on: Form_MasterStockpile -> Form_ItemContainer state: AddItem");
                this.Close();
            }
        }
    }
}
