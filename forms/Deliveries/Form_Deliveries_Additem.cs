using IMS.DBHandler;
using IMS.src;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.forms.Deliveries
{
    public partial class Form_Deliveries_Additem : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        DelItem deliveries;
        public Form_Deliveries_Additem(DatabaseHandler handler, SessionHandler session)
        {
            InitializeComponent();
            _handler = handler;
            _session = session;
            deliveries = new DelItem(_handler, _session);
            InitData();
        }
        private void InitData()
        {
            this.GetColumnData("IMS_RFN_SCAT", "SCAT_DES", cbCategory);
            this.GetColumnData("IMS_RFN_SCA", "SCA_DES", cbSCategory);
            this.GetColumnData("IMS_RFN_SUP", "SUP_DES", cbSupplier);
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string itemCode = this.GetItemCode(cbItem.Text);
            int amount = Int32.Parse(txtAmount.Text);
            string supplier = cbSupplier.Text;
            int cost = Int32.Parse(txtCost.Text);
            string branch = cbBranch.Text;

            if (deliveries.AddDelivery(itemCode, amount, supplier, branch, cost))
            {
                MessageBox.Show("Delivery Item Added!");
                //Audit
            }
            else
            {
                MessageBox.Show("Error adding Item!");
            }
        }

        private string GetItemCode(string itemName)
        {
            using (SqlDataReader reader = _handler.GetItemCode("IMS_SITE", "SITE_COD", itemName))
            {
                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    return value;
                }
            }
            return null;
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChkItems();
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

        private void cbSCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChkItems();
        }
    }
}
