using IMS.DBHandler;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.src
{
    internal class Supplies
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        public Supplies(DatabaseHandler handler, SessionHandler session)
        {
            _handler = handler;
            _session = session;
        }
        public bool AddItem(string code, string description, string category, string unit, string subcategory, string color)
        {
            string query = "Test";
            if (_handler.ExecuteNonQuery(query) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool EditItem()
        {
            string query = "Test";
            if (_handler.ExecuteNonQuery(query) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
