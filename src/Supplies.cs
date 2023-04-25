using IMS.DBHandler;
using MySqlX.XDevAPI;
using System;
using System.Collections;
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
            string query = "INSERT INTO IMS_SITE (SITE_COD, SITE_DES, SITE_SCAT, SITE_SCA, SITE_SUNT, SITE_SCOL, SITE_QOH)" +
                    $"VALUES ('{code}', '{description}', '{category}', '{subcategory}', '{unit}', '{color}', 0)";
            if (_handler.ExecuteNonQuery(query) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            return true;
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
