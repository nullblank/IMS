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
    public partial class Form_Deliveries : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        public Form_Deliveries(DatabaseHandler handler, SessionHandler session)
        {
            InitializeComponent();
            _handler = handler;
            _session = session;
            this.InitData();
        }

        public void InitData()
        {
            DataTable results = new DataTable();
            string query = "SELECT * FROM IMS_STOC";
            dgvDeliveries.DataSource = _handler.ExecuteQuery(query);
        }
    }
}
