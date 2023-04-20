using IMS.DBHandler;
using IMS.src;
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
        public Form_MasterStockpile(DatabaseHandler handler, SessionHandler session)
        {
            InitializeComponent();
            _handler = handler;
            _session = session;
            InitData(session, handler);
        }

        private void InitData(SessionHandler session, DatabaseHandler handler)
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
                Form_ItemContainer form = new Form_ItemContainer();
                audit.LogUserAction("Viewed the master stockpile.", _session);
                form.Show();
            }
            else
            {
                MessageBox.Show("WARNING: ILLEGAL ACCESS DETECTED. CLOSING WINDOW!");
                audit.LogAction("Illegal Access on: Form_Developer -> Form_MasterStockpile");
                this.Close();
            }
        }
    }
}
