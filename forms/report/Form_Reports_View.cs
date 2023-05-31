using IMS.DBHandler;
using IMS.src;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.forms.report
{
    public partial class Form_Reports_View : Form
    {
        DatabaseHandler handler;
        SessionHandler session;
        public Form_Reports_View(DatabaseHandler handler, SessionHandler session, ComboBox month, TextBox year, ComboBox Office, string table)
        {
            InitializeComponent();
            this.handler = handler;
            this.session = session;
            int mon = this.GetMonth(month.Text);
            switch (table)
            {
                case "IMS_SREQ":
                    
                    GetSREQ(mon, year.Text, Office.Text, table);
                    break;
                case "IMS_SDEL":
                    GetSDEL(mon, year.Text, Office.Text, table);
                    break;
            }
        }

        public DataTable GetSREQ(int month, string year, string Office, string table)
        {
            string query = "SELECT " +
                "SREQ_SRN AS [Supply Number], " +
                "SREQ_DTE AS [Date Requested], " +
                "SREQ_PUR AS [Purpose], " +
                "SREQ_RQU AS [Requesting User], " +
                "SREQ_OFF AS [Requesting Office], " +
                "SREQ_STAT AS [Status] " +
                $"FROM {table} " +
                $"WHERE MONTH({table.Substring(4)}_DTE) = {month} " +
                $"AND YEAR({table.Substring(4)}_DTE) = {year} " +
                $"AND {table.Substring(4)}_OFF = '{Office}'";

            DataTable dataTable = new DataTable();
            dgvView.DataSource = handler.ExecuteQuery(query);
            if (dataTable == null)
            {
                MessageBox.Show("ERROR! Datatable is null!");
                return null;
            }
            return dataTable;
        }

        public DataTable GetSDEL(int month, string year, string Office, string table)
        {
            string query = "SELECT " +
                "SDEL_SDN AS [Requesition Number], " +
                "SDEL_DTE AS [Date Requesitioned], " +
                "SDEL_RQU AS [Requesitioned User's ID], " +
                "SDEL_OFF AS [Office Requesitioned], " +
                "SDEL_COS AS [Total Cost of Requesition] " +
                $"FROM {table} " +
                $"WHERE MONTH({table.Substring(4)}_DTE) = {month} " +
                $"AND YEAR({table.Substring(4)}_DTE) = {year} " +
                $"AND {table.Substring(4)}_OFF = '{Office}'";

            DataTable dataTable = new DataTable();
            dgvView.DataSource = handler.ExecuteQuery(query);
            if (dataTable == null)
            {
                MessageBox.Show("ERROR! Datatable is null!");
                return null;
            }
            return dataTable;
        }

        private int GetMonth(string month)
        {
            switch (month)
            {
                case "January": return 1;
                case "February": return 2;
                case "March": return 3;
                case "April": return 4;
                case "May": return 5;
                case "June": return 6;
                case "July": return 7;
                case "August": return 8;
                case "September": return 9;
                case "October": return 10;
                case "November": return 11;
                case "December": return 12;
                default: return 0;
            }
        }
    }
}
