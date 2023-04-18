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
using MySqlX.XDevAPI.Common;
using System.Collections;

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

        public bool CreateUser(string cod, string username, string password, string permission, string office, string isActive)
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
                    query = $"SELECT COUNT(*) FROM IMS_USR WHERE USR_NME = '{username}'";
                    results = _handler.ExecuteQuery(query);
                    count = 0;
                    if (results.Rows.Count > 0)
                    {
                        count = Convert.ToInt32(results.Rows[0][0]);
                    }
                    if (count > 0)
                    {
                        MessageBox.Show("Username already exists!");
                        return false;
                    }
                    else
                    {
                        query = $"SELECT * FROM IMS_RFN_ROL WHERE ROL_DES = '{permission}'";
                        results = _handler.ExecuteQuery(query);
                        permission = results.Rows[0][0].ToString();
                        query = $"SELECT * FROM IMS_RFN_OFF WHERE OFF_DES = '{office}'";
                        results = _handler.ExecuteQuery(query);
                        office = results.Rows[0][0].ToString();
                        EncryptionHandler encrypt = new EncryptionHandler();
                        password = encrypt.Encrypt(password);
                        if (isActive == "Yes")
                        {
                            isActive = "1";
                        }
                        else
                        {
                            isActive = "0";
                        }
                        query = $"INSERT INTO IMS_USR (USR_COD, USR_NME, USR_PWD, USR_ROL, USR_OFF, USR_ACT) VALUES ('{cod}', '{username}', '{password}', '{permission}', '{office}', '{isActive}')";
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

        public bool UpdateUser(string oguser, string ogpass, string cod, string username, string password, string permission, string office, string isActive)
        {
            try
            {
                DialogResult option = MessageBox.Show("Are you sure you want to Update the records of this user?", "Confirm User Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (option == DialogResult.Yes)
                {
                    if (oguser == username && ogpass == password)
                    {
                        string query = $"SELECT * FROM IMS_RFN_ROL WHERE ROL_DES = '{permission}'";
                        DataTable results = _handler.ExecuteQuery(query);
                        permission = results.Rows[0][0].ToString();
                        query = $"SELECT * FROM IMS_RFN_OFF WHERE OFF_DES = '{office}'";
                        results = _handler.ExecuteQuery(query);
                        office = results.Rows[0][0].ToString();
                        EncryptionHandler encrypt = new EncryptionHandler();
                        //password = encrypt.Encrypt(password);
                        if (isActive == "Yes")
                        {
                            isActive = "1";
                        }
                        else
                        {
                            isActive = "0";
                        }
                        query = $"UPDATE IMS_USR SET USR_NME = '{username}', USR_PWD = '{password}', USR_ROL = '{permission}', USR_OFF = '{office}', USR_ACT = '{isActive}' WHERE USR_COD = '{cod}'";
                        if (_handler.ExecuteNonQuery(query) == 0)
                        {
                            return false;
                        }
                        else
                        {
                            Audit audit = new Audit(_handler);
                            audit.LogUserAction($"Updated Account. Username: {username}, Role: {permission}, Office: {office}", _session);
                            return true;
                        }
                    }
                    else if (oguser != username)
                    {
                        string query = $"SELECT COUNT(*) FROM IMS_USR WHERE USR_NME = '{username}'";
                        DataTable results = _handler.ExecuteQuery(query);
                        int count = 0;
                        if (results.Rows.Count > 0)
                        {
                            count = Convert.ToInt32(results.Rows[0][0]);
                        }
                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists!");
                            return false;
                        }

                        else
                        {
                            query = $"SELECT * FROM IMS_RFN_ROL WHERE ROL_DES = '{permission}'";
                            results = _handler.ExecuteQuery(query);
                            permission = results.Rows[0][0].ToString();
                            query = $"SELECT * FROM IMS_RFN_OFF WHERE OFF_DES = '{office}'";
                            results = _handler.ExecuteQuery(query);
                            office = results.Rows[0][0].ToString();
                            EncryptionHandler encrypt = new EncryptionHandler();
                            //password = encrypt.Encrypt(password);
                            if (isActive == "Yes")
                            {
                                isActive = "1";
                            }
                            else
                            {
                                isActive = "0";
                            }
                            query = $"UPDATE IMS_USR SET USR_NME = '{username}', USR_PWD = '{password}', USR_ROL = '{permission}', USR_OFF = '{office}', USR_ACT = '{isActive}' WHERE USR_COD = '{cod}'";
                            if (_handler.ExecuteNonQuery(query) == 0)
                            {
                                return false;
                            }
                            else
                            {
                                Audit audit = new Audit(_handler);
                                audit.LogUserAction($"Updated Account. Username: {username}, Role: {permission}, Office: {office}", _session);
                                return true;
                            }
                        }
                    }
                    else if (ogpass != password)
                    {
        
                        string query = $"SELECT * FROM IMS_RFN_ROL WHERE ROL_DES = '{permission}'";
                        DataTable results = _handler.ExecuteQuery(query);
                        permission = results.Rows[0][0].ToString();
                        query = $"SELECT * FROM IMS_RFN_OFF WHERE OFF_DES = '{office}'";
                        results = _handler.ExecuteQuery(query);
                        office = results.Rows[0][0].ToString();
                        EncryptionHandler encrypt = new EncryptionHandler();
                        password = encrypt.Encrypt(password);
                        if (isActive == "Yes")
                        {
                            isActive = "1";
                        }
                        else
                        {
                            isActive = "0";
                        }
                        query = $"UPDATE IMS_USR SET USR_NME = '{username}', USR_PWD = '{password}', USR_ROL = '{permission}', USR_OFF = '{office}', USR_ACT = '{isActive}' WHERE USR_COD = '{cod}'";
                        if (_handler.ExecuteNonQuery(query) == 0)
                        {
                            return false;
                        }
                        else
                        {
                            Audit audit = new Audit(_handler);
                            audit.LogUserAction($"Updated Account. Username: {username}, Role: {permission}, Office: {office}", _session);
                            return true;
                        }
                    }


                }
                else
                {
                    return false;
                }
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }
    }
}
