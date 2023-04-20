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
    }
}
