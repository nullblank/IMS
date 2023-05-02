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

namespace IMS.forms.requests_resupply
{
    public partial class Form_Resupply : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        public Form_Resupply(DatabaseHandler handler, SessionHandler session)
        {
            _handler = handler;
            _session = session;
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            this.GetColumnData("IMS_RFN_SCAT", "SCAT_DES", cbCategory);
            this.GetColumnData("IMS_RFN_SCA", "SCA_DES", cbSCategory);
            this.GetColumnData("IMS_RFN_BRA", "BRA_DES", cbBranch);
        }

        private void GetColumnData(string table, string column, ComboBox cb)
        {
            using (SqlDataReader reader = _handler.GetColumnData(table, column))
            {
                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    cb.Items.Add(value);
                }
            }
        }

        private void ChkItems()
        {
            cbItem.Items.Clear();
            cbItem.Text = "";
            if (String.IsNullOrEmpty(cbSCategory.Text))
            {
                this.GetItems(cbCategory.Text, null);
            }
            else
            {
                this.GetItems(cbCategory.Text, cbSCategory.Text);
            }
        }

        private void GetItems(string category, string sCategory)
        {
            using (SqlDataReader reader = _handler.GetCode("IMS_SITE", "SITE_DES", category, sCategory))
            {
                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    cbItem.Items.Add(value);
                }
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChkItems();
        }
    }
}
