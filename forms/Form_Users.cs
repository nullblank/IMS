using IMS.DBHandler;
using IMS.NetUtil;
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
    public partial class Form_Users : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        NetworkUtilities _netutil;
        public Form_Users(DatabaseHandler handler, SessionHandler session)
        {
            InitializeComponent();
            _handler = handler;
            _session = session;
            _netutil = new NetworkUtilities();
        }

        private void InitUsers()
        {
            if (_session.SessionExists() == true)
            {
                DataTable results = new DataTable();
                results = _handler.ExecuteQuery("SELECT * FROM IMS_USR");
                dgvUsers.DataSource = results;

            }
            else
            {
                MessageBox.Show("WARNING: ILLEGAL ACCESS DETECTED. CLOSING WINDOW!");
                Audit audit = new Audit(_handler);
                audit.LogAction("Illegal Access on: Form_Users");
                this.Hide();
            }
        }
        private void Form_Users_Load(object sender, EventArgs e)
        {
            InitUsers();
        }
    }
}
