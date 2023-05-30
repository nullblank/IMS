using IMS.DBHandler;
using IMS.forms.requests_deliveries;
using IMS.src;
using Microsoft.Office.Interop.Excel;
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
using DataTable = System.Data.DataTable;

namespace IMS.forms.requests_resupply
{
    public partial class Form_Satisfy : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        DataTable _table;
        DataGridViewRow _row;
        Form_Outbound _outbound;
        int _requestNumber;
        int _deliveryIndex;
        int _itemcode;

        public Form_Satisfy(DatabaseHandler handler, SessionHandler session, int requestNumber, Form_Outbound outbound)
        {
            _outbound = outbound;
            _handler = handler;
            _session = session;
            _requestNumber = requestNumber;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lvItems.Columns.Add("Item Code");
            lvItems.Columns.Add("Item");
            lvItems.Columns.Add("Quantity");
            ColumnHeader firstColumn = lvItems.Columns[0];
            ColumnHeader secondColumn = lvItems.Columns[1];
            firstColumn.Width = 100;
            secondColumn.Width = 75;

            lvSend.Columns.Add("Delivery Index");
            lvSend.Columns.Add("Item Code");
            lvSend.Columns.Add("Quantity");
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
                item.SubItems.Add(rows[2].ToString());
                lvItems.Items.Add(item);
            }
        }

        private void lvItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count > 0)
            {

                string itemCode = lvItems.SelectedItems[0].Text;
                string query = $"SELECT " +
                    $"STOC_IDX AS [Index], " +
                    $"STOC_COD AS [Item Code], " +
                    $"STOC_SUP AS [Supplier], " +
                    $"STOC_DTE AS [Delivery Date], " +
                    $"STOC_BRA AS [Branch], " +
                    $"STOC_COS AS [Cost], " +
                    $"STOC_QTY [Quantity] " +
                    $"FROM IMS_STOC WHERE STOC_COD = {itemCode} AND STOC_QTY <> 0";
                _table = _handler.ExecuteQuery(query);

                dgvStockpile.DataSource = _table;
            }
        }

        private void dgvStockpile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtAmount.Text = "";
                // Get the text of the clicked cell
                txtAmount.ReadOnly = false;
                DataGridViewRow row = dgvStockpile.Rows[e.RowIndex];
                if (!string.IsNullOrEmpty(row.Cells[0].Value.ToString()) || row.Cells[0].Value.ToString() != "")
                {

                    int deliveryIndex = Int32.Parse(row.Cells[0].Value.ToString());
                    int itemcode = Int32.Parse(row.Cells[1].Value.ToString());
                    _deliveryIndex = deliveryIndex;
                    _itemcode = itemcode;
                    _row = row;
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

            if (string.IsNullOrEmpty(txtAmount.Text) || txtAmount.Text == "")
            {
                MessageBox.Show("Please enter an amount.");
            }
            else
            {
                //DataRow row = _table.Rows[0];
                int stockpileQty = int.Parse(_row.Cells["Quantity"].Value.ToString()); //Quantity of delivery
                int amount = Int32.Parse(txtAmount.Text);
                if (amount > 0 && (stockpileQty - amount) >= 0 && (stockpileQty - amount <= stockpileQty))
                {
                    _row.Cells["Quantity"].Value = (stockpileQty - Int32.Parse(txtAmount.Text)).ToString();
                    dgvStockpile.DataSource = _table;
                    //fix this shit
                    double cost = double.Parse(_row.Cells["Cost"].Value.ToString());
                    double totalcost = cost * int.Parse(txtAmount.Text);
                    ListViewItem item = new ListViewItem(_deliveryIndex.ToString());
                    item.SubItems.Add(_itemcode.ToString());
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

        private void button3_Click(object sender, EventArgs e) //Finish delivery
        {
            DialogResult option = MessageBox.Show("Are you sure you want to finalize this order?", "Confirm Order Delivery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                DateTime now = DateTime.Now;

                if (lvSend.Items.Count > 0)
                {//change to get office from request
                    string office = null;
                    string qry = $"SELECT SREQ_OFF FROM IMS_SREQ WHERE SREQ_SRN = {_requestNumber}";
                    DataTable data = _handler.ExecuteQuery(qry);
                    if (data != null || data.Rows.Count != 0)
                    {
                        office = data.Rows[0][0].ToString();
                    }
                    else
                    {
                        office = "NA";
                    }

                    string query = "INSERT INTO IMS_SDEL " +
                        "(SDEL_SDN, SDEL_DTE, SDEL_RQU, SDEL_OFF, SDEL_COS) VALUES" +
                        $"({_requestNumber}, '{now}', '{_session.GetUserID()}', '{office}', 0)";
                    _handler.ExecuteNonQuery(query);
                    foreach (ListViewItem item in lvSend.Items)
                    {

                        string item_code = item.SubItems[1].Text;
                        DataTable table = new DataTable();
                        table = _handler.ExecuteQuery($"SELECT * FROM IMS_SITE WHERE SITE_COD = '{item_code}'");
                        if (table.Rows.Count > 0)
                        {
                            int amount = Int32.Parse(item.SubItems[2].Text);
                            string cost = item.SubItems[3].Text;
                            string tCost = item.SubItems[4].Text;

                            //int newQoh = Int32.Parse(table.Rows[0][7].ToString()) - Int32.Parse(txtAmount.Text);
                            //_handler.ExecuteNonQuery("UPDATE IMS_SITE " +
                            //    $"SET SITE_QOH = {newQoh} " + // 
                            //    $"WHERE SITE_COD = '{item_code}'");
                            query = "INSERT INTO IMS_SDD " +
                                "(SDD_SDN, SDD_DIDX, SDD_COD, SDD_COS, SDD_QTY, SDD_TCOS) VALUES" +
                                $"({_requestNumber}, {_deliveryIndex}, {item_code}, {cost}, {amount}, {tCost})";
                            _handler.ExecuteNonQuery(query);

                            query = "UPDATE IMS_STOC " +
                                $"SET STOC_QTY = STOC_QTY - {amount} " +
                                $"WHERE STOC_IDX = {Int32.Parse(item.SubItems[0].Text)}";
                            _handler.ExecuteNonQuery(query);
                        }
                        else
                        {
                            MessageBox.Show($"No item found with code '{item_code}' in IMS_SITE table.");
                        }
                    }
                    query = $"UPDATE IMS_SREQ SET SREQ_STAT = 'Delivered' WHERE SREQ_SRN = {_requestNumber}";
                    _handler.ExecuteNonQuery(query);
                    MessageBox.Show($"Updated Req#:{_requestNumber}; Status: 'DELIVERED'");
                    _outbound.InitData();
                    _outbound.clearList();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please add items to deliver.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lvSend.SelectedItems.Count > 0)
            {
                //Make sure it adds back the item's quantity after removing to the right index!
                // Retrieve the index of the selected item
                int index = lvSend.SelectedItems[0].Index;

                // Remove the item from the ListView control
                lvSend.Items.RemoveAt(index);
            }
        }
    }
}
