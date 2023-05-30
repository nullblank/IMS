using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.ComponentModel.DataAnnotations.Schema;
using IMS.DBHandler;

namespace IMS.src
{
    internal class Reports
    {
        DatabaseHandler _handler;
        public Reports(DatabaseHandler handler)
        {
            _handler = handler;
        }

        public DataTable GetSREQ(ComboBox month, TextBox year, ComboBox Office, string table)
        {
            int mon = this.GetMonth(month.Text);
            string query = "SELECT " +
                "SREQ_SRN AS [Supply Number], " +
                "SREQ_DTE AS [Date Requested], " +
                "SREQ_PUR AS [Purpose], " +
                "SREQ_RQU AS [Requesting User], " +
                "SREQ_OFF AS [Requesting Office], " +
                "SREQ_STAT AS [Status] " +
                $"FROM {table} " +
                $"WHERE MONTH({table.Substring(4)}_DTE) = {mon} " +
                $"AND YEAR({table.Substring(4)}_DTE) = {year.Text} " +
                $"AND {table.Substring(4)}_OFF = '{Office.Text}'";

            DataTable dataTable = new DataTable();
            dataTable = _handler.ExecuteQuery(query);
            if (dataTable == null)
            {
                MessageBox.Show("ERROR! Datatable is null!");
                return null;
            }
            return dataTable;
        }

        public DataTable GetSDEL(ComboBox month, TextBox year, ComboBox Office, string table)
        {
            int mon = this.GetMonth(month.Text);
            string query = "SELECT " +
                "SDEL_SDN AS [Requesition Number], " +
                "SDEL_DTE AS [Date Requesitioned], " +
                "SDEL_RQU AS [Requesitioned User's ID], " +
                "SDEL_OFF AS [Office Requesitioned], " +
                "SDEL_COS AS [Total Cost of Requesition] " +
                $"FROM {table} " +
                $"WHERE MONTH({table.Substring(4)}_DTE) = {mon} " +
                $"AND YEAR({table.Substring(4)}_DTE) = {year.Text} " +
                $"AND {table.Substring(4)}_OFF = '{Office.Text}'";

            DataTable dataTable = new DataTable();
            dataTable = _handler.ExecuteQuery(query);
            if (dataTable == null)
            {
                MessageBox.Show("ERROR! Datatable is null!");
                return null;
            }
            return dataTable;
        }
        public DataTable GetQueryRecords(ComboBox month, TextBox year, ComboBox Office, string table)
        {
            int mon = this.GetMonth(month.Text);
            string query = "SELECT * " +
                $"FROM {table} " +
                $"WHERE MONTH({table.Substring(4)}_DTE) = {mon} " +
                $"AND YEAR({table.Substring(4)}_DTE) = {year.Text} " +
                $"AND {table.Substring(4)}_OFF = '{Office.Text}'";

            DataTable dataTable = new DataTable();
            dataTable = _handler.ExecuteQuery(query);
            if (dataTable == null)
            {
                MessageBox.Show("ERROR! Datatable is null!");
                return null;
            }
            return dataTable;
        }

        public DataTable GetNonQueryRecords(string table)
        {
            string query = "SELECT * " +
                $"FROM {table}";
            DataTable dataTable = new DataTable();
            dataTable = _handler.ExecuteQuery(query);
            if (dataTable == null)
            {
                MessageBox.Show("ERROR! Datatable is null!");
                return null;
            }
            return dataTable;
        }
        public string SetFilePath(string type, string office, string month, string year)
        {
            DateTime time = DateTime.Now;
            //string realTime = time.ToString("MM-dd-yyyy_HH-mm-ss");
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|s*.*";
            saveFileDialog.FileName = $"{office}_{type}({month}-{year}).xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                return fileName;
            }
            else
            {
                return null;
            }
        }
        public bool ExporttoExcel(DataTable dataTable, string filePath)
        {
            try
            {
                //Create a new Excel application
                Excel.Application excelApp = new Excel.Application();
                //Create a new workbook
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Add();
                //Create a new worksheet
                Excel.Worksheet excelWorksheet = excelWorkbook.Sheets[1];
                //Set the column headers in the first row
                if (dataTable == null)
                {
                    MessageBox.Show("ERROR: DataTable does not exist!");
                    return false;
                }
                else
                {
                    int columnCount = dataTable.Columns.Count;
                    for (int i = 0; i < columnCount; i++)
                    {
                        excelWorksheet.Cells[1, i + 1] = dataTable.Columns[i].ColumnName;
                    }
                    //Populate the data in the remaining rows
                    int rowCount = dataTable.Rows.Count;
                    for (int i = 0; i < rowCount; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {
                            excelWorksheet.Cells[i + 2, j + 1] = dataTable.Rows[i][j].ToString();
                        }
                    }
                    //Save the workbook to the specified file path
                    excelWorkbook.SaveAs(filePath);
                    //Close the workbook and release the resources
                    excelWorkbook.Close();
                    excelApp.Quit();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error while exporting!: {e.Message}");
                return false;
            }
        }
        private int GetMonth(string month)
        {
            switch (month)
            {
                case "January":     return 1;
                case "February":    return 2;
                case "March":       return 3;
                case "April":       return 4;
                case "May":         return 5;
                case "June":        return 6;
                case "July":        return 7;
                case "August":      return 8;
                case "September":   return 9;
                case "October":     return 10;
                case "November":    return 11;
                case "December":    return 12;
                default:            return 0;
            }
        }
    }
}
