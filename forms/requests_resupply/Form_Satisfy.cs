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
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IMS.forms.requests_resupply
{
    public partial class Form_Satisfy : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        DataTable _table;
        int _requestNumber;
        int _deliveryIndex;

        public Form_Satisfy(DatabaseHandler handler, SessionHandler session, int requestNumber)
        {
            _handler = handler;
            _session = session;
            _requestNumber = requestNumber;
            InitializeComponent();
            lvItems.Columns.Add("Item Code");
            lvItems.Columns.Add("Item");
            lvItems.Columns.Add("Amount");
            ColumnHeader firstColumn = lvItems.Columns[0];
            ColumnHeader secondColumn = lvItems.Columns[1];
            firstColumn.Width = 100;
            secondColumn.Width = 75;

            lvSend.Columns.Add("Item");
            lvSend.Columns.Add("Amount");
            lvSend.Columns.Add("Cost/Item");
            lvSend.Columns.Add("Total cost");

            this.InitData();
        }

        private void InitData()
        {
            DataTable requestedItems = _handler.ExecuteQuery($"SELECT A.SRD_COD, B.SITE_DES, A.SRD_QTY " +
                $"FROM IMS_SRD A " +
                $"LEFT JOIN IMS_SITE B ON A.SRD_COD = B.SITE_COD " +
                $"WHERE A.SRD_SRN = {_requestNumber}");
            foreach (DataRow rows in requestedItems.Rows)
            {
                ListViewItem item = new ListViewItem(rows[0].ToString());
                item.SubItems.Add(rows[1].ToString());
                lvItems.Items.Add(item);
            }
        }

        private void lvItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count > 0)
            {

                string itemCode = lvItems.SelectedItems[0].Text;
                string query = $"SELECT * FROM IMS_STOC WHERE STOC_COD = {itemCode} AND STOC_QTY <> 0";
                _table = _handler.ExecuteQuery(query);

                dgvStockpile.DataSource = _table;
            }
        }

        private void dgvStockpile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the text of the clicked cell
                txtAmount.ReadOnly = false;
                DataGridViewRow row = dgvStockpile.Rows[e.RowIndex];
                if (!string.IsNullOrEmpty(row.Cells[0].Value.ToString()) || row.Cells[0].Value.ToString() != "")
                {

                    int deliveryIndex = Int32.Parse(row.Cells[0].Value.ToString());
                    _deliveryIndex = deliveryIndex;
                }
                else
                {
                    txtAmount.ReadOnly = true;
                }


            }
            else
            {
                txtAmount.ReadOnly = true;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            DataRow row = _table.Rows[0];
            int stockpileQty = Int32.Parse(row[6].ToString());
            if (string.IsNullOrEmpty(txtAmount.Text) || txtAmount.Text == "")
            {
                MessageBox.Show("Please enter an amount.");
            }
            else
            {
                if (Int32.Parse(txtAmount.Text) > 0 && (stockpileQty - (Int32.Parse(txtAmount.Text))) >= 0 && (stockpileQty - (Int32.Parse(txtAmount.Text)) <= stockpileQty))
                {
                    _table.Rows[0][6] = (stockpileQty - Int32.Parse(txtAmount.Text)).ToString();
                    dgvStockpile.DataSource = _table;
                    //add to listview send
                    double cost = double.Parse(_table.Rows[0][5].ToString());
                    double totalcost = cost * int.Parse(txtAmount.Text);
                    ListViewItem item = new ListViewItem(_deliveryIndex.ToString());
                    item.SubItems.Add(txtAmount.Text);
                    item.SubItems.Add(cost.ToString());
                    item.SubItems.Add(totalcost.ToString());
                    lvSend.Items.Add(item);
                    //
                    txtAmount.Text = "";
                }
                else
                {
                    MessageBox.Show("The amount you entered is beyond what it can provide. ");
                }
            }
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e) //FInish delivery
        {
            foreach (ListViewItem item in lvSend.Items)
            {
                //math to deduct
                
                string item_code = item.SubItems[0].Text;
                DataTable table = new DataTable();
                table = _handler.ExecuteQuery($"SELECT * FROM IMS_SITE WHERE SITE_COD = '{item_code}'");
                int amount = Int32.Parse(item.SubItems[1].Text);
                string cost = item.SubItems[2].Text;
                string tCost = item.SubItems[3].Text;

                int newQoh = Int32.Parse(table.Rows[0][7].ToString()) - amount;
                MessageBox.Show($"{item_code}, {amount}, {cost}, {tCost}");
                _handler.ExecuteNonQuery("UPDATE IMS_SITE " +
                    $"SET SITE_QOH = {newQoh} " + // 
                    $"WHERE SITE_COD = '{item_code}'");

                //Make table triggers
                //make tables to add these into

            }
        }
    }
}
