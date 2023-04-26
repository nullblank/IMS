using IMS.DBHandler;
using IMS.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.forms
{
    public partial class Form_ItemContainer : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        DataGridView _grid;
        DataGridViewCellEventArgs _e;
        bool _update = false;
        public Form_ItemContainer(DatabaseHandler handler, SessionHandler session)
        {
            InitializeComponent();
            _handler = handler;
            _session = session;
            InitItems();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_update)
            {
                this.UpdateItem();
            }
            else
            {
                this.AddItem();
            }

        }

        public bool UpdateItem()//update this
        {
            string code = txtCode.Text;
            txtCode.Enabled = false;
            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Code Cannot be empty.");
                return false;
            }
            string description = txtDescription.Text;
            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Description Cannot be empty.");
                return false;
            }
            string category = cbCategory.Text;
            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Category Cannot be empty.");
                return false;
            }
            string unit = cbUnit.Text;
            if (string.IsNullOrEmpty(unit))
            {
                MessageBox.Show("Unit Cannot be empty.");
                return false;
            }
            string subcategory = cbSCategory.Text;
            if (string.IsNullOrEmpty(subcategory) || subcategory == "--")
            {
                subcategory = null;
            }
            string color = cbColor.Text;
            if (string.IsNullOrEmpty(color) || color == "--")
            {
                color = null;
            }

            Supplies supplies = new Supplies(_handler, _session);
            if (supplies.EditItem(code, description, category, unit, subcategory, color))
            {
                MessageBox.Show("Item Added to Stockpile List!");
                Audit audit = new Audit(_handler);
                audit.LogUserAction($"Added Item to stockpile. " +
                    $"code: {code}, description: {description}, category: " +
                    $"{category}, unit: {unit}, subcategory: " +
                    $"{subcategory}, color: {color}", _session);
                this.Close();
                Form_MasterStockpile form = new Form_MasterStockpile(_handler, _session);
                form.InitData(_session, _handler);
                return true;
            }
            else
            {
                MessageBox.Show("ERROR ADDING ITEM.");
                return false;
            }
        }

        public void SetState(bool state)
        {
            _update = state;
        }

        public void SetData(DataGridView grid, DataGridViewCellEventArgs e)
        {
            _grid = grid;
            _e = e;
            DataGridViewRow row = grid.Rows[e.RowIndex];
            txtCode.Text = row.Cells["SITE_COD"].Value.ToString();
            txtDescription.Text = row.Cells["SITE_DES"].Value.ToString();
            this.MatchCell("SITE_SCAT", cbCategory, e);
            this.MatchCell("SITE_SCA", cbSCategory, e);
            this.MatchCell("SITE_SUNT", cbUnit, e);
            this.MatchCell("SITE_SCOL", cbColor, e);
        }
        public void ClearData()
        {
            txtCode.Text = "";
            txtDescription.Text = "";
            cbCategory.Text = "";
            cbSCategory.Text = "";
            cbUnit.Text = "";
            cbColor.Text = "";
        }
        private void MatchCell(string column, ComboBox comboBox, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = _grid.Rows[e.RowIndex];
            int itemIndex = comboBox.FindStringExact(selectedRow.Cells[column].Value.ToString());
            if (itemIndex >= 0)
            {
                comboBox.SelectedIndex = itemIndex;
            }
        }

        private bool AddItem()
        {
            string code = txtCode.Text;
            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Code Cannot be empty.");
                return false;
            }
            string description = txtDescription.Text;
            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Description Cannot be empty.");
                return false;
            }
            string category = cbCategory.Text;
            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Category Cannot be empty.");
                return false;
            }
            string unit = cbUnit.Text;
            if (string.IsNullOrEmpty(unit))
            {
                MessageBox.Show("Unit Cannot be empty.");
                return false;
            }
            string subcategory = cbSCategory.Text;
            if (string.IsNullOrEmpty(subcategory) || subcategory == "--")
            {
                subcategory = null;
            }
            string color = cbColor.Text;
            if (string.IsNullOrEmpty(color) || color == "--")
            {
                color = null;
            }

            Supplies supplies = new Supplies(_handler, _session);
            if (supplies.AddItem(code, description, category, unit, subcategory, color))
            {
                MessageBox.Show("Item Added to Stockpile List!");
                Audit audit = new Audit(_handler);
                audit.LogUserAction($"Added Item to stockpile. " +
                    $"code: {code}, description: {description}, category: " +
                    $"{category}, unit: {unit}, subcategory: " +
                    $"{subcategory}, color: {color}", _session);
                this.Close();
                Form_MasterStockpile form = new Form_MasterStockpile(_handler, _session);
                form.InitData(_session, _handler);
                return true;
            }
            else
            {
                MessageBox.Show("ERROR ADDING ITEM.");
                return false;
            }
        }

        private void Form_ItemContainer_Load(object sender, EventArgs e)
        {
            

        }

        public void InitItems()
        {
            using (SqlDataReader reader = _handler.GetColumnData("IMS_RFN_SCAT", "SCAT_DES"))
            {
                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    cbCategory.Items.Add(value);
                }
            }
            using (SqlDataReader reader = _handler.GetColumnData("IMS_RFN_SCA", "SCA_DES"))
            {
                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    cbSCategory.Items.Add(value);
                }
            }
            using (SqlDataReader reader = _handler.GetColumnData("IMS_RFN_SUNT", "SUNT_DES"))
            {
                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    cbUnit.Items.Add(value);
                }
            }
            using (SqlDataReader reader = _handler.GetColumnData("IMS_RFN_SCOL", "SCOL_DES"))
            {
                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    cbColor.Items.Add(value);
                }
            }
            _handler.CloseConnection();
        }

        private void Form_ItemContainer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
