using IMS.DBHandler;
using IMS.src;
using Mysqlx.Resultset;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.forms.requests_resupply
{
    public partial class Form_Requests : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        int _referenceNumber;
        public Form_Requests(DatabaseHandler handler, SessionHandler session)
        {
            _handler = handler;
            _session = session;
            InitializeComponent();
            lvRequestItems.Columns.Add("Item");
            lvRequestItems.Columns.Add("Amount");
            ColumnHeader firstColumn = lvRequestItems.Columns[0];
            ColumnHeader secondColumn = lvRequestItems.Columns[1];
            firstColumn.Width = 300;
            secondColumn.Width = 75;
            InitData();
        }
        public void InitData()
        {
            DataTable results = new DataTable();
            string query = "SELECT " +
                "SREQ_SRN AS 'Request Number', " +
                "SREQ_DTE AS 'Date Requested', " +
                "SREQ_PUR AS 'Purpose', " +
                "SREQ_RQU AS 'Requested by', " +
                "SREQ_STAT AS 'Request Status'" +
                " FROM IMS_SREQ";
            dgvRequests.DataSource = _handler.ExecuteQuery(query);
        }
        private void Requests_Load(object sender, EventArgs e)
        {
            lblUser.Text = _session.GetSessionUsername();
            lblRole.Text = _session.GetRole();
            lblOffice.Text = _session.GetOffice();
        }

        private void btnResupply_Click(object sender, EventArgs e)
        {
            Form_Resupply form = new Form_Resupply(_handler, _session, this);
            form.Show();
        }

        private void dgvRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lvRequestItems.Items.Clear();
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvRequests.Rows[e.RowIndex];
                if (!string.IsNullOrEmpty(row.Cells["Request Number"].Value.ToString()) || row.Cells["Request Number"].Value.ToString() != "")
                {
                    int requestCode = Int32.Parse(row.Cells["Request Number"].Value.ToString());
                    _referenceNumber = requestCode;
                    DataTable requestedItems = _handler.ExecuteQuery($"SELECT B.SITE_DES, A.SRD_QTY " +
                        $"FROM IMS_SRD A " +
                        $"LEFT JOIN IMS_SITE B ON A.SRD_COD = B.SITE_COD " +
                        $"WHERE A.SRD_SRN = {Int32.Parse(row.Cells["Request Number"].Value.ToString())}");
                    foreach (DataRow rows in requestedItems.Rows)
                    {
                        ListViewItem item = new ListViewItem(rows[0].ToString());
                        item.SubItems.Add(rows[1].ToString());
                        lvRequestItems.Items.Add(item);
                    }
                }
            }
            
        }

        private void btnCancelResupply_Click(object sender, EventArgs e)
        {
            DataTable table = _handler.ExecuteQuery($"SELECT * FROM IMS_SREQ WHERE SREQ_SRN = {_referenceNumber}");
            if (table.Rows.Count != 0) //Add: && if order_status == pending)
            {
                DataRow row = table.Rows[0];
                if (row["SREQ_STAT"].ToString() == "Pending")
                {
                    _handler.ExecuteNonQuery($"DELETE FROM IMS_SREQ WHERE SREQ_SRN = {_referenceNumber}");
                    _handler.ExecuteNonQuery($"DELETE FROM IMS_SRD WHERE SRD_SRN = {_referenceNumber}");
                    this.InitData();
                }
                else
                {
                    MessageBox.Show("Error: It's too late to cancel this request. Please go to the IMO for further inquiries.");
                }
            }
        }
    }
}
