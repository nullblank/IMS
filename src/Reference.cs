using IMS.DBHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.src
{
    internal class Reference
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        public Reference(DatabaseHandler handler, SessionHandler session)
        {
            _handler = handler;
            _session = session;
        }
        public bool AddEntry(TextBox code, TextBox description, string table, string prefix)
        {
            string query = $"INSERT INTO {table} " +
                $"({prefix}_COD, {prefix}_DES) " +
                $"VALUES ('{code.Text}', '{description.Text}')";
            if (_handler.ExecuteNonQuery(query) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool UpdateEntry(TextBox code, TextBox description, string table, string prefix)
        {
            string query = $"UPDATE {table} SET {prefix}_DES = '{description.Text}' WHERE {prefix}_COD = {code.Text}";
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
