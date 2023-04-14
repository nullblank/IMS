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
        NetworkUtilities _networkUtilities;
        public Audit(DatabaseHandler handler)
        {
            _handler = handler;
            _networkUtilities = new NetworkUtilities();
        }
        public void LogAction(string action) //Logs actions outside of a user's session
        {
            try
            {
                string columns = "LOG_ACT, LOG_LIP, LOG_MADR, LOG_DNME";
                string values = $"'{action}', '{_networkUtilities.GetLocalIP()}', '{_networkUtilities.GetMacAddress()}', '{_networkUtilities.GetComputerName()}'";
                _handler.ExecuteQuery($"INSERT INTO IMS_LOG ({columns}) VALUES ({values})");
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
                string columns = "LOG_USR, LOG_ROL, LOG_ACT, LOG_LIP, LOG_MADR, LOG_DNME, LOG_SEID";
                string values = $"'{session.GetSessionUsername()}', '{session.GetRole()}', '{action}', '{_networkUtilities.GetLocalIP()}', '{_networkUtilities.GetMacAddress()}', '{_networkUtilities.GetComputerName()}', '{session.GetSessionID()}'";
                _handler.ExecuteQuery($"INSERT INTO IMS_LOG ({columns}) VALUES ({values})");
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
