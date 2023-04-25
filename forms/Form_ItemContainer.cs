using IMS.DBHandler;
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
    public partial class Form_ItemContainer : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        public Form_ItemContainer(DatabaseHandler handler, SessionHandler session)
        {
            InitializeComponent();
            _handler = handler;
            _session = session;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void additem()
        {
            string code = txtCode.Text;
            string description = txtDescription.Text;
            string category = cbCategory.Text;
            string unit = cbUnit.Text;
            string subcategory = cbSCategory.Text;
            string color = cbColor.Text;
            Supplies supplies = new Supplies(_handler, _session);
            //supplies.AddItem();
        }

        private void Form_ItemContainer_Load(object sender, EventArgs e)
        {
            //InitUsers();
            using (SqlDataReader reader = _handler.GetColumnData("IMS_RFN_SCAT", "SCAT_DES"))
            {
                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    cbCategory.Items.Add(value);
                }
            }
            using (SqlDataReader reader = _handler.GetColumnData("IMS_RFN_SCA", "SCA_DES"))
            {
                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    cbSCategory.Items.Add(value);
                }
            }
            using (SqlDataReader reader = _handler.GetColumnData("IMS_RFN_SUNT", "SUNT_DES"))
            {
                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    cbUnit.Items.Add(value);
                }
            }
            using (SqlDataReader reader = _handler.GetColumnData("IMS_RFN_SCOL", "SCOL_DES"))
            {
                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    cbColor.Items.Add(value);
                }
            }
            _handler.CloseConnection();
        }
    }
}
