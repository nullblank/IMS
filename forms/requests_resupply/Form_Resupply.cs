using IMS.DBHandler;
using IMS.src;
using MySqlX.XDevAPI.Relational;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IMS.forms.requests_resupply
{
    public partial class Form_Resupply : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        DataTable _table;
        public Form_Resupply(DatabaseHandler handler, SessionHandler session)
        {
            _handler = handler;
            _session = session;
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Item_Name");
            table.Columns.Add("Amount");
            lvItems.Columns.Add("Item Name");
            lvItems.Columns[0].Width = 400;
            lvItems.Columns.Add("Amount");
            lvItems.Columns[1].Width = 100;
            _table = table;
            this.GetColumnData("IMS_RFN_SCAT", "SCAT_DES", cbCategory);
            this.GetColumnData("IMS_RFN_SCA", "SCA_DES", cbSCategory);
        }

        private void GetColumnData(string table, string column, System.Windows.Forms.ComboBox cb)
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

        private void btnSave_Click(object sender, EventArgs e) //Add
        {
            AddToList();
        }

        private void AddToList()
        {
            _table = new DataTable();
            _table.Columns.Add("Item_Name");
            _table.Columns.Add("Amount");
            _table.Rows.Add(cbItem.Text, txtAmount.Text);
            lvItems.View = View.Details;
            foreach (DataRow row in _table.Rows)
            {
                ListViewItem item = new ListViewItem(row["Item_Name"].ToString());
                item.SubItems.Add(row["Amount"].ToString());
                lvItems.Items.Add(item);
            }
        }

        private void cbSCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChkItems();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count > 0)
            {
                // Retrieve the index of the selected item
                int index = lvItems.SelectedItems[0].Index;

                // Remove the item from the ListView control
                lvItems.Items.RemoveAt(index);
            }
        }
    }
}
