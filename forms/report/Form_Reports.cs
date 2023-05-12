using IMS.DBHandler;
using IMS.src;
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

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {

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
    }
}
