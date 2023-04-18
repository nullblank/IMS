﻿using IMS.DBHandler;
using IMS.src;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
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
            Audit audit = new Audit(_handler);
            if (_session.SessionExists())
            {
                Form_Logs form_Logs = new Form_Logs(_handler, _session);
                audit.LogUserAction("Viewed the logs.", _session);
                form_Logs.Show();
            }
            else
            {
                audit.LogAction("Ilegal access to logs!");
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Audit audit = new Audit(_handler);
            if (_session.SessionExists())
            {
                Form_Users form_Logs = new Form_Users(_handler, _session);
                audit.LogUserAction("Viewed the user management.", _session);
                form_Logs.Show();
            }
            else
            {
                MessageBox.Show("WARNING: ILLEGAL ACCESS DETECTED. CLOSING WINDOW!");
                audit.LogAction("Illegal Access on: Form_Admin -> Form_Users");
                this.Hide();
            }
        }

        private void btnSCAT_Click(object sender, EventArgs e)
        {

        }

        private void btnSCA_Click(object sender, EventArgs e)
        {

        }

        private void btnSCOL_Click(object sender, EventArgs e)
        {

        }

        private void btnSUNT_Click(object sender, EventArgs e)
        {

        }

        private void btnOFF_Click(object sender, EventArgs e)
        {

        }

        private void btnSUP_Click(object sender, EventArgs e)
        {

        }
    }
}
