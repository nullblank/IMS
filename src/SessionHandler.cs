using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.src
{
    public class SessionHandler
    {
        string _session;
        string _username;
        public SessionHandler(string username)
        {
            GenerateSessionID();
            _username = username;
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
