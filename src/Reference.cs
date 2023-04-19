using IMS.DBHandler;
using System;
using System.Collections.Generic;
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
            _handler.ExecuteNonQuery($"INSERT INTO {table} " +
                $"({prefix}_COD, {prefix}_DES) " +
                $"VALUES ('{code.Text}', '{description.Text}')");
            return true;
        }

        public bool UpdateEntry()
        {
            return true;
        }
    }
}
