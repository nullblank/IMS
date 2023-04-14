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
        DatabaseHandler handler;
        private void InitDb() //Initialize Database handler
        {
            handler = new DatabaseHandler();
        }
        public void CheckConnection() //Checks connection between client and database
        {
            InitDb();
            handler.CheckConnection();
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
        private string GetComputerName() //Gets Desktop's name
        {
            string computerName = Environment.MachineName;
            return computerName;
        }
        private void LogAction(string action) //Logs actions outside of a user's session
        {
            string localIp = GetLocalIP();
            string macAddr = GetMacAddress();
            string desktopName = GetComputerName();
            try
            {
                handler.ExecuteQuery($"INSERT INTO IMS_LOG (LOG_ACT, LOG_LIP, LOG_MADR, LOG_DNME) VALUES ('{action}', '{localIp}', '{macAddr}', '{desktopName}')");
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                handler.CloseConnection();
            }
        }
        private void LogUserAction(string action, SessionHandler session) //Logs actions done within a user's session
        {
            string localIp = GetLocalIP();
            string macAddr = GetMacAddress();
            string desktopName = GetComputerName();
            try
            {
                handler.ExecuteQuery($"INSERT INTO IMS_LOG (LOG_USR, LOG_ROL, LOG_ACT, LOG_LIP, LOG_MADR, LOG_DNME, LOG_SEID) VALUES ('{session.GetSessionUsername()}', '{session.GetRole()}', '{action}', '{localIp}', '{macAddr}', '{desktopName}', '{session.GetSessionID()}')");
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                handler.CloseConnection();
            }
        }
        public bool Login(string user, string pass) //Attempts login with given username and password. | Encrypt Later
        {
            try
            {
                InitDb();
                if (handler != null)
                {
                    DataTable results = handler.ExecuteQuery($"SELECT * FROM IMS_USR WHERE USR_NME COLLATE Latin1_General_CS_AS = '{user}' AND USR_PWD COLLATE Latin1_General_CS_AS = '{pass}'");
                    if (results.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successful!");
                        int role = (int)results.Rows[0][4];
                        SessionHandler session = new SessionHandler();
                        session.NewSession(user, role, handler);
                        LogUserAction("Successful Login", session);
                        switch (role)
                        {
                            case 1:
                                Form_AdminPanel form_AdminPanel = new Form_AdminPanel(handler, session);
                                form_AdminPanel.Show();
                                break;
                        }
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login!");
                        LogAction("Attempted Login!");
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
                handler.CloseConnection();
            }
        }
    }
}