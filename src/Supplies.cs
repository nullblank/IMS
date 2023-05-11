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
            string query = "INSERT INTO IMS_SITE (SITE_COD, SITE_DES, SITE_SCAT, SITE_SCA, SITE_SUNT, SITE_SCOL, SITE_QOH, SITE_BV)" +
                    $"VALUES ('{code}', '{description}', '{category}', '{subcategory}', '{unit}', '{color}', 0, 0)";
            if (_handler.ExecuteNonQuery(query) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool EditItem(string code, string description, string category, string unit, string subcategory, string color)
        {
            string query = $"UPDATE IMS_SITE SET SITE_DES = '{description}', SITE_SCAT = '{category}', SITE_SCA = '{subcategory}', SITE_SUNT = '{unit}', SITE_SCOL = '{color}' WHERE SITE_COD = '{code}'";
            DialogResult option = MessageBox.Show("Are you sure you want to Update the records of this Item?", "Confirm Item Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                if (_handler.ExecuteNonQuery(query) == 0)
                {
                    return false;
                }
                else
                {
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
