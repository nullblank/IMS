using IMS.DBHandler;
using IMS.forms.Deliveries;
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
            string query = "SELECT " +
                "IMS_STOC.STOC_IDX," +
                "IMS_SITE.SITE_DES," +
                "IMS_STOC.STOC_DTE," +
                "IMS_STOC.STOC_BRA," +
                "IMS_STOC.STOC_COS," +
                "IMS_STOC.STOC_QTY " +
                "FROM IMS_STOC " +
                "JOIN IMS_SITE ON IMS_STOC.STOC_COD = IMS_SITE.SITE_COD";
            dgvDeliveries.DataSource = _handler.ExecuteQuery(query);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Deliveries_Additem form = new Form_Deliveries_Additem(_handler, _session);
            form.Show();
        }
    }
}
