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
        DataTable _request;
        Form_Requests _form;
        public Form_Resupply(DatabaseHandler handler, SessionHandler session, Form_Requests form)
        {
            _table = handler.ExecuteQuery("SELECT * FROM IMS_SITE");
            _handler = handler;
            _session = session;
            _form = form;
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            lvItems.Columns.Add("Item Code");
            lvItems.Columns[0].Width = 100;
            lvItems.Columns.Add("Item Name");
            lvItems.Columns[1].Width = 400;
            lvItems.Columns.Add("Quantity");
            lvItems.Columns[2].Width = 100;
            this.GetColumnData("IMS_RFN_SCAT", cbCategory);
            this.GetColumnData("IMS_RFN_SCA", cbSCategory);
        }

        private void GetColumnData(string table, System.Windows.Forms.ComboBox cb)
        {
            using (SqlDataReader reader = _handler.GetTableData(table))
            {
                while (reader.Read())
                {
                    //Everytime an item is added to the combo box, it links the selection to what item from
                    //the stockpile is selected based on the index it was added to
                    //for example, if the first (0) item added was about paperReams which has a code of 2
                    //if a user selects index 0, then code is = 2
                    //
                    string value = reader.GetString(2);
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
            _table = new DataTable();
            _table.Columns.Add("Item_Code");
            _table.Columns.Add("Item_Name");
            using (SqlDataReader reader = _handler.GetCode("IMS_SITE", category, sCategory))
            {
                while (reader.Read())
                {
                    _table.Rows.Add(reader.GetString(1), reader.GetString(2));
                    cbItem.Items.Add(reader.GetString(2));
                }
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChkItems();
        }

        private void btnSave_Click(object sender, EventArgs e) //Add
        {
            if (string.IsNullOrEmpty(txtAmount.Text) || txtAmount.Text == "")
            {
                MessageBox.Show("Enter an amount!");
            }
            else if (string.IsNullOrEmpty(cbItem.Text) || cbItem.Text == "")
            {
                MessageBox.Show("Please select an item.");
            }
            else
            {
                AddToList();
                cbCategory.SelectedIndex = 0;
                cbSCategory.SelectedIndex = 0;
                txtAmount.Text = "";
            }

        }

        private void AddToList()
        {
            _request = new DataTable();
            _request.Columns.Add("Item_Code");
            _request.Columns.Add("Item_Name");
            _request.Columns.Add("Amount");
            DataRow data = _table.Rows[cbItem.SelectedIndex];
            _request.Rows.Add(data[0].ToString(), data[1].ToString(), txtAmount.Text);
            lvItems.View = View.Details;

            foreach (DataRow row in _request.Rows)//update to include item code aswell
            {
                ListViewItem item = new ListViewItem(row["Item_Code"].ToString());
                item.SubItems.Add(row["Item_Name"].ToString());
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
        private int GenerateRequestID()
        {
            int length = 9;
            string chars = "0123456789";
            Random random = new Random();
            string randomString = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            int result = Int32.Parse(randomString);
            return result;
        }
        private void btnRequest_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure these are the items you want to request?", "Finalize", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (lvItems.Items.Count == 0)
                {
                    MessageBox.Show("Please add items to request first!");
                    return;
                }
                else if (string.IsNullOrEmpty(txtPurpose.Text) || txtPurpose.Text == "")
                {
                    MessageBox.Show("Please state the purpose of your request");
                    return;
                }
                else
                {

                    int requestNumber = this.GenerateRequestID();
                    DataTable requestChk = _handler.ExecuteQuery($"SELECT * FROM IMS_SREQ WHERE SREQ_SRN = {requestNumber}");
                    if (requestChk.Rows.Count != 0)
                    {
                        requestNumber = this.GenerateRequestID();

                    }
                    DateTime currentDate = DateTime.Now;
                    string query = "INSERT INTO IMS_SREQ (SREQ_SRN, SREQ_DTE, SREQ_PUR, SREQ_RQU, SREQ_OFF, SREQ_STAT) " +
                    $"VALUES ({requestNumber}, '{currentDate}', '{txtPurpose.Text}', '{_session.GetSessionUsername()}', '{_session.GetOffice()}', 'Pending')";
                    _handler.ExecuteNonQuery(query);
                    foreach (ListViewItem item in lvItems.Items)
                    {
                        query = "INSERT INTO IMS_SRD (SRD_SRN, SRD_COD, SRD_QTY) "
                        + $"VALUES ({requestNumber}, {item.SubItems[0].Text}, {item.SubItems[2].Text})";
                        _handler.ExecuteNonQuery(query);
                    }
                    _form.InitData();
                    MessageBox.Show($"Items Requested! Your Request# is: {requestNumber}. You will need this to claim your request.");
                    this.Close();
                }
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
