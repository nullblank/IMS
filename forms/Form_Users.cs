using IMS.DBHandler;
using IMS.NetUtil;
using IMS.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IMS.forms
{
    public partial class Form_Users : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        NetworkUtilities _netutil;
        string _state;
        string _orgusername;
        string _orgpassword;
        public Form_Users(DatabaseHandler handler, SessionHandler session)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _handler = handler;
            _session = session;
            _netutil = new NetworkUtilities();
        }

        private void InitUsers()
        {
            if (_session.SessionExists() == true)
            {
                DataTable results = new DataTable();
                string query = "SELECT u.USR_IDX, u.USR_COD, u.USR_NME, u.USR_PWD," +
                    " CASE WHEN u.USR_ROL = r.ROL_COD THEN r.ROL_DES ELSE NULL END AS ROL_DES," +
                    " CASE WHEN u.USR_OFF = o.OFF_COD THEN o.OFF_DES ELSE NULL END AS OFF_DES," +
                    " CASE WHEN u.USR_ACT = '1' THEN 'Yes' ELSE 'No' END AS USR_ACT" +
                    " FROM IMS_USR u" +
                    " LEFT JOIN IMS_RFN_ROL r ON u.USR_ROL = r.ROL_COD" +
                    " LEFT JOIN IMS_RFN_OFF o ON u.USR_OFF = o.OFF_COD";
                results = _handler.ExecuteQuery(query);
                dgvUsers.DataSource = results;

            }
            else
            {
                MessageBox.Show("WARNING: ILLEGAL ACCESS DETECTED. CLOSING WINDOW!");
                Audit audit = new Audit(_handler);
                audit.LogAction("Illegal Access on: Form_Users");
                this.Hide();
            }
        }
        private void Form_Users_Load(object sender, EventArgs e)
        {
            InitUsers();
            using (SqlDataReader reader = _handler.GetColumnData("IMS_RFN_OFF", "OFF_DES"))
            {
                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    cbOffice.Items.Add(value);
                }
            }
            using (SqlDataReader reader = _handler.GetColumnData("IMS_RFN_ROL", "ROL_DES"))
            {
                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    cbPerms.Items.Add(value);
                }
            }
            _handler.CloseConnection();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvUsers.Rows[e.RowIndex];
                txtID.Text = selectedRow.Cells["USR_COD"].Value.ToString();
                txtUsername.Text = selectedRow.Cells["USR_NME"].Value.ToString();
                txtPassword.Text = selectedRow.Cells["USR_PWD"].Value.ToString();
                MatchCell(e, "ROL_DES", cbPerms);
                MatchCell(e, "OFF_DES", cbOffice);
                MatchCell(e, "USR_ACT", cbActive);
                if (txtID.Text == "")
                {
                    btnUpdate.Enabled = false;
                }
                else
                {
                    btnUpdate.Enabled = true;
                }
            }
            else
            {

            }
        }

        private void MatchCell(DataGridViewCellEventArgs e, string column, ComboBox comboBox)
        {
            DataGridViewRow selectedRow = dgvUsers.Rows[e.RowIndex];
            int itemIndex = comboBox.FindStringExact(selectedRow.Cells[column].Value.ToString());
            if (itemIndex >= 0)
            {
                comboBox.SelectedIndex = itemIndex;
            }
        }

        private void ToggleState(string state)
        {
            switch (state)
            {
                case "New":
                    _state = state;
                    txtID.ReadOnly = false; txtID.Clear();
                    txtUsername.ReadOnly = false; txtUsername.Clear();
                    txtPassword.ReadOnly = false; txtPassword.Clear();
                    cbPerms.Enabled = true; cbPerms.SelectedIndex = 0;
                    cbOffice.Enabled = true; cbOffice.SelectedIndex = 0;
                    cbActive.Enabled = true; cbActive.SelectedIndex = 0;
                    dgvUsers.Enabled = false;
                    btnNew.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    break;
                case "Update":
                    _state = state;
                    txtUsername.ReadOnly = false;
                    txtPassword.ReadOnly = false;
                    cbPerms.Enabled = true;
                    cbOffice.Enabled = true;
                    cbActive.Enabled = true;
                    dgvUsers.Enabled = false;
                    btnNew.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    break;
                case "Gen":
                    _state = state;
                    txtID.ReadOnly = true; txtID.Clear();
                    txtUsername.ReadOnly = true; txtUsername.Clear();
                    txtPassword.ReadOnly = true; txtPassword.Clear();
                    cbPerms.Enabled = false; cbPerms.SelectedIndex = 0;
                    cbOffice.Enabled = false; cbOffice.SelectedIndex = 0;
                    cbActive.Enabled = false; cbActive.SelectedIndex = 0;
                    dgvUsers.Enabled = true;
                    btnNew.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    break;
                default:
                    MessageBox.Show("Warning: Unknown State.");
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ToggleState("New");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_state == "New")
            {
                //Query here then
                if (InputCheck(txtUsername.Text, "username") && InputCheck(txtPassword.Text, "password"))
                {
                    User user = new User(_handler, _session);
                    if (user.CreateUser(txtID.Text, txtUsername.Text, txtPassword.Text, cbPerms.Text, cbOffice.Text, cbActive.Text))
                    {
                        ToggleState("Gen");
                        InitUsers();
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password Does not meet requirements!");
                }
            }
            else if (_state == "Update")
            {
                //Query here then
                if (InputCheck(txtUsername.Text, "username") && InputCheck(txtPassword.Text, "password"))
                {
                    User user = new User(_handler, _session);
                    if (user.UpdateUser(_orgusername, _orgpassword, txtID.Text, txtUsername.Text, txtPassword.Text, cbPerms.Text, cbOffice.Text, cbActive.Text))
                    {
                        ToggleState("Gen");
                        InitUsers();
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password Does not meet requirements!");
                }
            }
        }

        private bool InputCheck(string stringtocheck, string type)
        {
            // Regex pattern for username: only letters and numbers, at least 6 characters long
            string usernamePattern = "^[a-zA-Z0-9]{6,}$";
            // Regex pattern for password: at least 8 characters long, containing at least one uppercase letter, one lowercase letter, and one number
            string passwordPattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,}$";
            if (type == "username")
            {
                bool isUsernameValid = Regex.IsMatch(stringtocheck, usernamePattern);
                return isUsernameValid;
            }
            else
            {
                bool isPasswordValid = Regex.IsMatch(stringtocheck, passwordPattern);
                return isPasswordValid;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ToggleState("Gen");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ToggleState("Update");
            _orgusername = txtUsername.Text;
            _orgpassword = txtPassword.Text;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
