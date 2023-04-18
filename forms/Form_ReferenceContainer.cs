using IMS.DBHandler;
using IMS.src;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.forms
{
    public partial class Form_ReferenceContainer : Form
    {
        public Form_ReferenceContainer(DatabaseHandler handler, SessionHandler session, string table)
        {
            InitializeComponent();
            InitContainer(table, session, handler);
        }
        private void InitContainer(string table, SessionHandler session, DatabaseHandler handler)
        {
            DataTable results = new DataTable();
            string query = $"SELECT * FROM {table}";
            results = handler.ExecuteQuery(query);
            dgvContainer.DataSource = results;
        }
    }
}
