using IMS.DBHandler;
using IMS.NetUtil;
using IMS.src;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.forms
{
    public partial class Form_Logs : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        public Form_Logs(DatabaseHandler handler, SessionHandler session)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _handler = handler;
            _session = session;
        }

        private void InitLogs()
        {
            if (_session.SessionExists() == true)
            {
                DataTable results = new DataTable();
                results = _handler.ExecuteQuery("SELECT TOP 50 * FROM IMS_LOG ORDER BY LOG_TMP DESC");
                dgvLogs.DataSource = results;
                dgvLogs.Columns[3].Width = 150;
                dgvLogs.Columns[8].Width = 200;

            }
            else
            {
                MessageBox.Show("WARNING: ILLEGAL ACCESS DETECTED. CLOSING WINDOW!");
                Audit audit = new Audit(_handler);
                audit.LogAction("Illegal Access on: Form_Logs");
                this.Hide();
            }
        }

        private void Form_Logs_Load(object sender, EventArgs e)
        {
            InitLogs();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Audit audit = new Audit(_handler);
            audit.LogUserAction("User refreshed the logs.", _session);
            InitLogs();
        }
    }
}
