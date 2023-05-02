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

namespace IMS.forms.requests_resupply
{
    public partial class Form_Requests : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        public Form_Requests(DatabaseHandler handler, SessionHandler session)
        {
            _handler = handler;
            _session = session;
            InitializeComponent();
            InitData();
        }
        private void InitData()
        {
            DataTable results = new DataTable();
            string query = "SELECT * FROM IMS_SREQ";
            dgvRequests.DataSource = _handler.ExecuteQuery(query);
        }
        private void Requests_Load(object sender, EventArgs e)
        {
            lblUser.Text = _session.GetSessionUsername();
            lblRole.Text = _session.GetRole();
            lblOffice.Text = _session.GetOffice();
        }

        private void btnResupply_Click(object sender, EventArgs e)
        {
            Form_Resupply form = new Form_Resupply(_handler, _session);
            form.Show();
        }
    }
}
