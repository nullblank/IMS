using IMS.DBHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.src
{
    internal class Deliveries
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        public Deliveries(DatabaseHandler handler, SessionHandler session)
        {
            _handler = handler;
            _session = session;
        }

        public bool AddDelivery()
        {
            //Add sumshit here
            return false;
        }

        public bool RemoveDelivery()
        {
            //Add sumshit here
            return false;
        }
    }
}
