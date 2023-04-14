using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IMS.src
{
    public class SessionHandler
    {
        string _session;
        string _username;
        public SessionHandler(string username)
        {
            //Something something...
        }
        public void NewSession(string username)
        {
            GenerateSessionID();
            _username = username;
        }
        public bool SessionExists()
        {
            return _session != null && _username != null;
        }
        public string GetSessionUsername()
        {
            return _username;
        }
        public string GetSessionID()
        {
            return _session;
        }
        public void DestroySession()
        {
            _session = null;
            _username = null;
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
