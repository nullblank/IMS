using Google.Protobuf.WellKnownTypes;
using IMS.DBHandler;
using IMS.forms.Deliveries;
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

namespace IMS.forms
{
    public partial class Form_Deliveries : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        DateTime _date;
        public Form_Deliveries(DatabaseHandler handler, SessionHandler session)
        {
            InitializeComponent();
            _handler = handler;
            _session = session;
            this.InitData();
        }

        public void InitData()
        {
            DataTable results = new DataTable();
            string query = "SELECT " +
                "IMS_STOC.STOC_IDX AS 'Index'," +
                "IMS_SITE.SITE_DES AS 'Description'," +
                "IMS_STOC.STOC_SUP AS 'Supplier'," +
                "IMS_STOC.STOC_DTE AS 'Date Created'," +
                "IMS_STOC.STOC_BRA AS 'Branch'," +
                "IMS_STOC.STOC_COS AS 'CPI'," +
                "IMS_STOC.STOC_QTY AS 'Quantity' " +
                "FROM IMS_STOC " +
                "JOIN IMS_SITE ON IMS_STOC.STOC_COD = IMS_SITE.SITE_COD";
            dgvDeliveries.DataSource = _handler.ExecuteQuery(query);
        }

        public void InitDataQuery(int itemcode)
        {
            DataTable results = new DataTable();
            string query = "SELECT " +
                "IMS_STOC.STOC_IDX AS Stock_Index," +
                "IMS_SITE.SITE_DES AS Stock_Description," +
                "IMS_STOC.STOC_SUP AS Stock_Supplier," +
                "IMS_STOC.STOC_DTE AS Stock_DateCreated," +
                "IMS_STOC.STOC_BRA AS Stock_Branch," +
                "IMS_STOC.STOC_COS AS Stock_CPI," +
                "IMS_STOC.STOC_QTY AS Stock_Quantity " +
                "FROM IMS_STOC " +
                "JOIN IMS_SITE ON IMS_STOC.STOC_COD = IMS_SITE.SITE_COD " +
                $"WHERE IMS_STOC.STOC_COD = {itemcode}";
            dgvDeliveries.DataSource = _handler.ExecuteQuery(query);
            btnAddDelivery.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Deliveries_Additem form = new Form_Deliveries_Additem(_handler, _session, this);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DelItem deliver = new DelItem(_handler, _session);
            deliver.RemoveDelivery(_date);
            this.InitData();
        }

        private void dgvDeliveries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string chk = dgvDeliveries.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (string.IsNullOrEmpty(chk) || chk == "")
                {
                    button1.Enabled = false;
                }
                else
                {
                    DataGridViewRow clickedRow = dgvDeliveries.Rows[e.RowIndex];
                    DataGridViewCell targetCell = clickedRow.Cells[3];
                    if (DateTime.TryParse(targetCell.Value.ToString(), out DateTime dateValue))
                    {
                        _date = dateValue;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Datetime", "Error!");
                    }
                    button1.Enabled = true;
                }
            }
        }
    }
}
