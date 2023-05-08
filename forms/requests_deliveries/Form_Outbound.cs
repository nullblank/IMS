using IMS.DBHandler;
using IMS.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.forms.requests_deliveries
{
    public partial class Form_Outbound : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        int _referenceNumber;
        public Form_Outbound(DatabaseHandler handler, SessionHandler session)
        {
            _handler = handler;
            _session = session;
            InitializeComponent();
            lvItems.Columns.Add("Item");
            lvItems.Columns.Add("Amount");
            this.InitData();
        }
        private void InitData()
        {
            string query = "SELECT " +
                "SREQ_SRN AS 'Request#', " +
                "SREQ_DTE AS 'Date Requested', " +
                "SREQ_STAT AS 'Request Status'" +
                " FROM IMS_SREQ";
            dgvRequests.DataSource = _handler.ExecuteQuery(query);
        }

        private void dgvRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lvItems.Items.Clear();
            DataGridViewRow row = dgvRequests.Rows[e.RowIndex];
            if (!string.IsNullOrEmpty(row.Cells["Request#"].Value.ToString()) || row.Cells["Request#"].Value.ToString() != "")
            {
                int requestCode = Int32.Parse(row.Cells["Request#"].Value.ToString());
                _referenceNumber = requestCode;
                DataTable requestedItems = _handler.ExecuteQuery($"SELECT B.SITE_DES, A.SRD_QTY " +
                    $"FROM IMS_SRD A " +
                    $"LEFT JOIN IMS_SITE B ON A.SRD_COD = B.SITE_COD " +
                    $"WHERE A.SRD_SRN = {Int32.Parse(row.Cells["Request#"].Value.ToString())}");
                foreach (DataRow rows in requestedItems.Rows)
                {
                    ListViewItem item = new ListViewItem(rows[0].ToString());
                    item.SubItems.Add(rows[1].ToString());
                    lvItems.Items.Add(item);
                }
                requestedItems = _handler.ExecuteQuery($"SELECT * FROM IMS_SREQ WHERE SREQ_SRN = {_referenceNumber}");
                DataRow row1 = requestedItems.Rows[0];
                txtRequestNumber.Text = _referenceNumber.ToString();
                txtPurpose.Text = row1[3].ToString();
                txtOffice.Text = row1[5].ToString();
                txtUser.Text = row1[4].ToString();
            }
        }
    }
}
