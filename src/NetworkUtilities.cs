using IMS.DBHandler;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Configuration;
using IMS.src;
using IMS.forms;

namespace IMS.NetUtil
{
    public class NetworkUtilities
    {
        DatabaseHandler _handler;
        Audit audit;
        private void InitDb() //Initialize Database handler
        {
            _handler = new DatabaseHandler();
        }
        public void CheckConnection() //Checks connection between client and database
        {
            InitDb();
            _handler.CheckConnection();
        }
        public string GetLocalIP() //Gets current local IP address
        {
            try
            {
                string localIpAddress = "";
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList.Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork))
                {
                    localIpAddress = ip.ToString();
                    break;
                }
                return localIpAddress;
            }
            catch (NetworkInformationException ex)
            {
                MessageBox.Show($"Network Error: {ex.Message}");
                return null;
            }
        }
        public string GetMacAddress() //Gets computer's MAC Address
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            string macAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (macAddress == string.Empty) // only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    macAddress = adapter.GetPhysicalAddress().ToString();
                    if (!string.IsNullOrEmpty(macAddress))
                    {
                        macAddress = string.Join(":", Enumerable.Range(0, macAddress.Length / 2)
                            .Select(i => macAddress.Substring(i * 2, 2)));
                    }
                }
            }
            return macAddress;
        }
        public string GetComputerName() //Gets Desktop's name
        {
            string computerName = Environment.MachineName;
            return computerName;
        }
        public bool Login(string user, string pass) //Attempts login with given username and password. | Encrypt Later
        {
            try
            {
                InitDb();
                if (_handler != null)
                {
                    DataTable results = _handler.ExecuteQuery($"SELECT * FROM IMS_USR WHERE USR_NME COLLATE Latin1_General_CS_AS = '{user}' AND USR_PWD COLLATE Latin1_General_CS_AS = '{pass}'");
                    if (results.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successful!");
                        int role = (int)results.Rows[0][4];
                        SessionHandler session = new SessionHandler();
                        audit = new Audit(_handler, session);
                        session.NewSession(user, role, _handler);
                        
                        audit.LogUserAction("Successful Login", session);
                        switch (role)
                        {
                            case 1:
                                Form_AdminPanel form_AdminPanel = new Form_AdminPanel(_handler, session);
                                form_AdminPanel.Show();
                                break;
                        }
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login!");
                        audit = new Audit(_handler);
                        audit.LogAction("Attempted Login!");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Database connection not initialized.");
                    return false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally //Close connection after everything else
            {
                _handler.CloseConnection();
            }
        }
    }
}