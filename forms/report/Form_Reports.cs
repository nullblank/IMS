﻿using IMS.DBHandler;
using IMS.src;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DataTable = System.Data.DataTable;

namespace IMS.forms.report
{
    public partial class Form_Reports : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        public Form_Reports(DatabaseHandler handler, SessionHandler session)
        {
            InitializeComponent();
            _handler = handler;
            _session = session;
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string realTime = time.ToString("MM-dd-yyyy_HH-mm-ss");
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|s*.*";
            saveFileDialog.FileName = $"Requests_{cbOffice.Text}({cbMonth.Text}-{txtYear.Text}){realTime}.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                txtSavePath.Text = fileName;
                // Use fileName variable to do something with the selected file location
            }
        }

        private void btnExRequests_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSavePath.Text) || string.IsNullOrWhiteSpace(txtSavePath.Text))
            {
                MessageBox.Show("Please select a save path.");
            }
            else
            {
                string table = "IMS_SREQ";
                Reports report = new Reports(_handler);
                DataTable dataTable = report.GetQueryRecords(cbMonth, txtYear, cbOffice, table);
                if (report.ExporttoExcel(dataTable, txtSavePath.Text))
                {
                    MessageBox.Show($"Export Finished! Exported to: {txtSavePath.Text}");
                }
            }
        }
    }
}
