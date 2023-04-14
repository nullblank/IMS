using IMS.DBHandler;
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
            _handler = handler;
            _session = session;
        }

        private void Form_Logs_Load(object sender, EventArgs e)
        {
            if (_session.SessionExists() == true)
            {
                DataTable results = new DataTable();
                results = _handler.ExecuteQuery("SELECT * FROM IMS_LOG");
                dgvLogs.DataSource = results;
                
            }
            
        }
    }
}
