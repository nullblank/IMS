﻿using IMS.DBHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

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

        public bool AddDelivery(string itemCode, int amount, string supplier, string branch,  double cost)
        {
            DialogResult result = MessageBox.Show("Are you sure these are the items you want to request?", "Finalize", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DateTime now = DateTime.Now;
                string query = "INSERT INTO IMS_STOC (STOC_COD, STOC_SUP, STOC_DTE, STOC_BRA, STOC_COS, STOC_QTY)" +
                    $"VALUES ('{itemCode}', '{supplier}', '{now}', '{branch}', {cost}, {amount})";
                string queryLog = "INSERT INTO IMS_STOC_LOG (STOC_COD, STOC_SUP, STOC_DTE, STOC_BRA, STOC_COS, STOC_QTY, STOC_TCOS)" +
                    $"VALUES ('{itemCode}', '{supplier}', '{now}', '{branch}', {cost}, {amount}, {cost * amount})";
                if (_handler.ExecuteNonQuery(query) == 0)
                {
                    return false;
                }
                else
                {
                    _handler.ExecuteNonQuery(queryLog);
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        public bool RemoveDelivery(DateTime date)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to remove this record?", "Finalize", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = $"DELETE FROM IMS_STOC WHERE STOC_DTE = '{date:yyyy-MM-dd HH:mm:ss.fffffff}';";
                string queryLog = $"DELETE FROM IMS_STOC_LOG WHERE STOC_DTE = '{date:yyyy-MM-dd HH:mm:ss.fffffff}';";
                if (_handler.ExecuteNonQuery(query) == 0)
                {
                    return false;
                }
                else
                {
                    _handler.ExecuteNonQuery(queryLog);
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
