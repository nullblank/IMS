using IMS.DBHandler;
using IMS.forms.report;
using IMS.forms.requests_resupply;
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
            lvItems.Columns.Add("Quantity");
            ColumnHeader firstColumn = lvItems.Columns[0];
            ColumnHeader secondColumn = lvItems.Columns[1];
            firstColumn.Width = 275;
            secondColumn.Width = 75;
            this.InitData();
        }
        private void InitData()
        {
            string query = "SELECT " +
                "SREQ_SRN AS 'Request#', " +
                "SREQ_DTE AS 'Date Requested', " +
                "SREQ_STAT AS 'Request Status'" +
                " FROM IMS_SREQ " +
                "WHERE SREQ_STAT <> 'Delivered'";
            dgvRequests.DataSource = _handler.ExecuteQuery(query);
        }

        private void dgvRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lvItems.Items.Clear();
            // Check that the clicked cell is not a header cell
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
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

        private void btnPending_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE IMS_SREQ SET SREQ_STAT = 'Pending' WHERE SREQ_SRN = {_referenceNumber}";
            _handler.ExecuteNonQuery(query);
            MessageBox.Show($"Updated Req#:{_referenceNumber}; Status: 'PENDING'");
            this.InitData();
        }

        private void btnDenied_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE IMS_SREQ SET SREQ_STAT = 'Denied' WHERE SREQ_SRN = {_referenceNumber}";
            _handler.ExecuteNonQuery(query);
            MessageBox.Show($"Updated Req#:{_referenceNumber}; Status: 'DENIED'");
            this.InitData();
        }

        private void btnProcessing_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE IMS_SREQ SET SREQ_STAT = 'Processing' WHERE SREQ_SRN = {_referenceNumber}";
            _handler.ExecuteNonQuery(query);
            MessageBox.Show($"Updated Req#:{_referenceNumber}; Status: 'PROCESSING'");
            this.InitData();
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE IMS_SREQ SET SREQ_STAT = 'Delivered' WHERE SREQ_SRN = {_referenceNumber}";
            _handler.ExecuteNonQuery(query);
            MessageBox.Show($"Updated Req#:{_referenceNumber}; Status: 'DELIVERED'");
            this.InitData();
        }

        private void btnSatisfy_Click(object sender, EventArgs e)
        {
            Form_Satisfy form = new Form_Satisfy(_handler, _session, _referenceNumber);
            form.Show();
        }

        private void btnStockpile_Click(object sender, EventArgs e)
        {
            Form_MasterStockpile form = new Form_MasterStockpile(_handler, _session);
            form.Show();
        }

        private void btnDeliveries_Click(object sender, EventArgs e)
        {
            Form_Deliveries form = new Form_Deliveries(_handler, _session);
            form.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Form_Reports form = new Form_Reports(_handler, _session);
            form.Show();
        }
    }
}
