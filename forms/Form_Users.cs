using IMS.DBHandler;
using IMS.NetUtil;
using IMS.src;
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
                string query = "SELECT u.USR_IDX, u.USR_COD, u.USR_NME, u.USR_PWD," +
                    " CASE WHEN u.USR_ROL = r.ROL_COD THEN r.ROL_DES ELSE NULL END AS ROL_DES," +
                    " CASE WHEN u.USR_OFF = o.OFF_COD THEN o.OFF_DES ELSE NULL END AS OFF_DES" +
                    " FROM IMS_USR u" +
                    " LEFT JOIN IMS_RFN_ROL r ON u.USR_ROL = r.ROL_COD" +
                    " LEFT JOIN IMS_RFN_OFF o ON u.USR_OFF = o.OFF_COD";
                results = _handler.ExecuteQuery(query);
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
            using (SqlDataReader reader = _handler.GetColumnData("IMS_RFN_OFF", "OFF_DES"))
            {
                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    cbOffice.Items.Add(value);
                }
            }
            using (SqlDataReader reader = _handler.GetColumnData("IMS_RFN_ROL", "ROL_DES"))
            {
                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    cbPerms.Items.Add(value);
                }
            }
            _handler.CloseConnection();
        }
    }
}
