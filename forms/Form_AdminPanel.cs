using IMS.DBHandler;
using IMS.src;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace IMS.forms
{
    public partial class Form_AdminPanel : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        public Form_AdminPanel(DatabaseHandler handler, SessionHandler session)
        {
            InitializeComponent();
            _session = session;
            _handler = handler;
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            if (_session.SessionExists() == true)
            {
                this.Hide();
            }
        }
    }
}
