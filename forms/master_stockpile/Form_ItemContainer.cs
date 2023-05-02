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
        Form_MasterStockpile _masterstockpile;
        bool _update = false;
        public Form_ItemContainer(DatabaseHandler handler, SessionHandler session, Form_MasterStockpile form)
        {
            InitializeComponent();
            _handler = handler;
            _session = session;
            _masterstockpile = form;
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
                _masterstockpile.InitData(_session, _handler);
            }
            else
            {
                this.AddItem();
                _masterstockpile.InitData(_session, _handler);
            }

        }

        public bool UpdateItem()//update this
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
            if (string.IsNullOrEmpty(category) || category == "--")
            {
                MessageBox.Show("Category Cannot be empty.");
                return false;
            }
            string unit = cbUnit.Text;
            if (string.IsNullOrEmpty(unit) || unit == "--")
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
                MessageBox.Show("Item Updated!!");
                Audit audit = new Audit(_handler);
                audit.LogUserAction($"UPDATED Item to stockpile. " +
                    $"code: {code}, description: {description}, category: " +
                    $"{category}, unit: {unit}, subcategory: " +
                    $"{subcategory}, color: {color}", _session);
                this.Hide();
                Form_MasterStockpile form = new Form_MasterStockpile(_handler, _session);
                form.InitData(_session, _handler);
                return true;
            }
            else
            {
                MessageBox.Show("ERROR UPDATING ITEM.");
                return false;
            }
        }

        public void SetState(bool state)
        {
            _update = state;
            if (state)
            {
                txtCode.ReadOnly = true;
            }
            else
            {
                txtCode.ReadOnly = false;
            }
        }

        public void SetData(DataGridView grid, DataGridViewCellEventArgs e)
        {
            _grid = grid;
            _e = e;
            this.ClearData();
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
            cbCategory.SelectedIndex = 0;
            cbSCategory.SelectedIndex = 0;
            cbUnit.SelectedIndex = 0;
            cbColor.SelectedIndex = 0;
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
            if (string.IsNullOrEmpty(category) || category == "--")
            {
                MessageBox.Show("Category Cannot be empty.");
                return false;
            }
            string unit = cbUnit.Text;
            if (string.IsNullOrEmpty(unit) || unit == "--")
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

            //put code check here
            if (this.CodeExists(code))
            {
                if (supplies.AddItem(code, description, category, unit, subcategory, color))
                {
                    MessageBox.Show("Item Added to Stockpile List!");
                    Audit audit = new Audit(_handler);
                    audit.LogUserAction($"Added Item to stockpile. " +
                        $"code: {code}, description: {description}, category: " +
                        $"{category}, unit: {unit}, subcategory: " +
                        $"{subcategory}, color: {color}", _session);
                    this.Hide();
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
            else
            {
                MessageBox.Show("Item ID already exists!");
                return false;
            }
        }

        private bool CodeExists(string code)
        {
            string query = $"SELECT COUNT(*) FROM IMS_SITE WHERE SITE_COD = '{code}'";
            DataTable results = _handler.ExecuteQuery(query);
            int count = 0;
            if (results.Rows.Count > 0)
            {
                count = Convert.ToInt32(results.Rows[0][0]);
            }
            if (count > 0)
            {
                return false;
            }
            else
            {
                return true;
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

        }

        private void Form_ItemContainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                _masterstockpile.InitData(_session, _handler);
                this.Hide();
            }
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
