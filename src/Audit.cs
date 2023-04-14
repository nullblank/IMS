using IMS.DBHandler;
using IMS.NetUtil;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.src
{
    internal class Audit
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        NetworkUtilities _networkUtilities;
        string _localIp;
        string _macAddr;
        string _desktopName;
        public Audit(DatabaseHandler handler, SessionHandler session)
        {
            _handler = handler;
            _session = session;
            _networkUtilities = new NetworkUtilities();
            _localIp = _networkUtilities.GetLocalIP();
            _macAddr = _networkUtilities.GetMacAddress();
            _desktopName = _networkUtilities.GetComputerName();
        }
        public Audit(DatabaseHandler handler)
        {
            _handler = handler;
            _networkUtilities = new NetworkUtilities();
        }
        public void LogAction(string action) //Logs actions outside of a user's session
        {
            try
            {
                _handler.ExecuteQuery($"INSERT INTO IMS_LOG (LOG_ACT, LOG_LIP, LOG_MADR, LOG_DNME) VALUES ('{action}', '{_localIp}', '{_macAddr}', '{_desktopName}')");
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                _handler.CloseConnection();
            }
        }
        public void LogUserAction(string action, SessionHandler session) //Logs actions done within a user's session
        {
            try
            {
                _handler.ExecuteQuery($"INSERT INTO IMS_LOG (LOG_USR, LOG_ROL, LOG_ACT, LOG_LIP, LOG_MADR, LOG_DNME, LOG_SEID) VALUES ('{session.GetSessionUsername()}', '{session.GetRole()}', '{action}', '{_localIp}', '{_macAddr}', '{_desktopName}', '{session.GetSessionID()}')");
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                _handler.CloseConnection();
            }
        }
    }
}
