using IMS.DBHandler;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace IMS.src
{
    internal class User
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        public User(DatabaseHandler handler, SessionHandler session)
        {
            _handler = handler;
            _session = session;
        }

        public bool CreateUser(string cod, string username, string password, string permission, string office)
        {
            try
            {
                DialogResult option = MessageBox.Show("Are you sure you want to create this user?", "Confirm User Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (option == DialogResult.Yes)
                {
                    string query = $"SELECT COUNT(*) FROM IMS_USR WHERE USR_COD = '{cod}'";
                    DataTable results = _handler.ExecuteQuery(query);
                    int count = 0;
                    if (results.Rows.Count > 0)
                    {
                        count = Convert.ToInt32(results.Rows[0][0]);
                    }
                    if (count > 0)
                    {
                        MessageBox.Show("User ID already exists!");
                        return false;
                    }
                    else
                    {
                        query = $"SELECT COUNT(*) FROM IMS_RFN_ROL WHERE ROL_DES = '{permission}'";
                        results = _handler.ExecuteQuery(query);
                        permission = results.Rows[0][0].ToString();
                        query = $"SELECT COUNT(*) FROM IMS_RFN_OFF WHERE OFF_DES = '{office}'";
                        results = _handler.ExecuteQuery(query);
                        office = results.Rows[0][0].ToString();
                        EncryptionHandler encrypt = new EncryptionHandler();
                        password = encrypt.Encrypt(password);
                        query = $"INSERT INTO IMS_USR (USR_COD, USR_NME, USR_PWD, USR_ROL, USR_OFF, USR_ACT) VALUES ('{cod}', '{username}', '{password}', '{permission}', '{office}', 0)";
                        if (_handler.ExecuteNonQuery(query) == 0)
                        {
                            return false;
                        }
                        else
                        {
                            Audit audit = new Audit(_handler);
                            audit.LogUserAction($"Created Account. Username: {username}, Role: {permission}, Office: {office}", _session);
                            return true;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }
    }
}
