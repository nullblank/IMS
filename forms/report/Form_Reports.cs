using IMS.DBHandler;
using IMS.src;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DataTable = System.Data.DataTable;

namespace IMS.forms.report
{
    //REDO THIS ENTIRE THING, I HATE IT - Diego
    public partial class Form_Reports : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        public Form_Reports(DatabaseHandler handler, SessionHandler session)
        {
            InitializeComponent();
            _handler = handler;
            _session = session;
            this.GetColumnData("IMS_RFN_OFF", "OFF_DES", cbOffice);
        }
        private void GetColumnData(string table, string column, System.Windows.Forms.ComboBox cb)
        {
            using (SqlDataReader reader = _handler.GetColumnData(table, column))
            {
                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    cb.Items.Add(value);
                }
            }
        }
        private void txtYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsDigit((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            if (txtYear.Text.Length >= 4 && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }
        private void btnExRequests_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbMonth.Text) || string.IsNullOrEmpty(cbOffice.Text) || string.IsNullOrEmpty(txtYear.Text))
            {
                MessageBox.Show("Please make sure the Office, Month, and Year fields are not empty.");
            }
            else
            {
                Reports reports = new Reports(_handler);
                DataTable table = reports.GetQueryRecords(cbMonth, txtYear, cbOffice, "IMS_SREQ");
                if (table != null)// If query did not throw back error. 
                {
                    if (table.Rows.Count != 0 && table.Rows.Count > 0) //if data exists within user parameters
                    {
                        string filepath = reports.SetFilePath("Requests", cbOffice.Text, cbMonth.Text, txtYear.Text);
                        if (!string.IsNullOrEmpty(filepath)) //if path exists and not user cancelled
                        {
                            if (reports.ExporttoExcel(table, filepath)) //if exporting was succesfful
                            {
                                MessageBox.Show($"Success! Exported to: {filepath}");
                            }
                        }
                        else { return; }
                    }
                    else
                    {
                        MessageBox.Show("No records found for the indicated office, month, and year. ");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Table was null!");
                }
            }
        }

        private void btnExResupplies_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbMonth.Text) || string.IsNullOrEmpty(cbOffice.Text) || string.IsNullOrEmpty(txtYear.Text)) //if fields are empty
            {
                MessageBox.Show("Please make sure the Office, Month, and Year fields are not empty.");
            }
            else
            {
                Reports reports = new Reports(_handler);
                DataTable table = reports.GetQueryRecords(cbMonth, txtYear, cbOffice, "IMS_SDEL");
                if (table != null)// If query did not throw back error. 
                {
                    if (table.Rows.Count != 0 && table.Rows.Count > 0) //if data exists within user parameters
                    {
                        string filepath = reports.SetFilePath("Resupplies", cbOffice.Text, cbMonth.Text, txtYear.Text);
                        if (!string.IsNullOrEmpty(filepath)) //if path exists and not user cancelled
                        {
                            if (reports.ExporttoExcel(table, filepath)) //if exporting was succesfful
                            {
                                MessageBox.Show($"Success! Exported to: {filepath}");
                            }
                        }
                        else { return; }
                    }
                    else
                    {
                        MessageBox.Show("No records found for the indicated office, month, and year. ");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Table was null!");
                }
            }
        }

        private void btnExRequestItems_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports(_handler);
            DataTable table = reports.GetNonQueryRecords("IMS_SRD");
            if (table != null)// If query did not throw back error. 
            {
                if (table.Rows.Count != 0 && table.Rows.Count > 0) //if data exists within user parameters
                {
                    string filepath = reports.SetFilePath("Requests", cbOffice.Text, cbMonth.Text, txtYear.Text);
                    if (!string.IsNullOrEmpty(filepath)) //if path exists and not user cancelled
                    {
                        if (reports.ExporttoExcel(table, filepath)) //if exporting was succesfful
                        {
                            MessageBox.Show($"Success! Exported to: {filepath}");
                        }
                    }
                    else { return; }
                }
                else
                {
                    MessageBox.Show("No records found for the indicated office, month, and year. ");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Table was null!");
            }
        }

        private void btnExResuppliedItems_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports(_handler);
            DataTable table = reports.GetNonQueryRecords("IMS_SDD");
            if (table != null)// If query did not throw back error. 
            {
                if (table.Rows.Count != 0 && table.Rows.Count > 0) //if data exists within user parameters
                {
                    string filepath = reports.SetFilePath("Requests", cbOffice.Text, cbMonth.Text, txtYear.Text);
                    if (!string.IsNullOrEmpty(filepath)) //if path exists and not user cancelled
                    {
                        if (reports.ExporttoExcel(table, filepath)) //if exporting was succesfful
                        {
                            MessageBox.Show($"Success! Exported to: {filepath}");
                        }
                    }
                    else { return; }
                }
                else
                {
                    MessageBox.Show("No records found for the indicated office, month, and year. ");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Table was null!");
            }
        }
    }
}