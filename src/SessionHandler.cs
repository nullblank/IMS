using IMS.DBHandler;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IMS.src
{
    public class SessionHandler
    {
        string _session;
        string _userId;
        string _username;
        string _role;
        public SessionHandler()
        {
            //Something something...
        }
        public void NewSession(string username, int role, DatabaseHandler handler)
        {
            GenerateSessionID();
            DataTable results = handler.ExecuteQuery($"SELECT * FROM IMS_RFN_ROL WHERE ROL_COD  = '{role.ToString()}'");
            _username = username;
            _role = results.Rows[0][2].ToString();
            results = handler.ExecuteQuery($"SELECT * FROM IMS_USR WHERE USR_NME  = '{username}'");
            _userId = results.Rows[0][0].ToString();
        }
        public bool SessionExists()
        {
            return _session != null && _username != null;
        }
        public string GetRole()
        {
            return _role;
        }
        public string GetSessionUsername()
        {
            return _username;
        }
        public string GetUserID()
        {
            return _userId;
        }
        public string GetSessionID()
        {
            return _session;
        }
        public void DestroySession()
        {
            _session = null;
            _username = null;
            _role = null;
        }
        private void GenerateSessionID()
        {
            int length = 10;
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            string randomString = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            _session = randomString;
        }
    }
}
