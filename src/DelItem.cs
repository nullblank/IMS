using IMS.DBHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.src
{
    internal class DelItem
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        public DelItem(DatabaseHandler handler, SessionHandler session)
        {
            _handler = handler;
            _session = session;
        }

        public bool AddDelivery(string code, string supplier, string date, string branch, string cost, int quantiddie)
        {
            string query = "INSERT INTO IMS_STOC (STOC_COD, STOC_SUP, STOC_DTE, STOC_BRA, STOC_COS, STOC_QTY)" +
                $"VALUES ()";
            if (_handler.ExecuteNonQuery(query) == 0)
            {
                return false;
            }
            else
            {

                return true;
            }
        }

        public bool RemoveDelivery()
        {
            //Add sumshit here
            return false;
        }
    }
}
