using IMS.DBHandler;
using IMS.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.forms.Deliveries
{
    public partial class Form_Deliveries_Additem : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        DelItem deliveries;
        public Form_Deliveries_Additem(DatabaseHandler handler, SessionHandler session)
        {
            InitializeComponent();
            _handler = handler;
            _session = session;
            deliveries = new DelItem(_handler, _session);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (deliveries.AddDelivery())
            {
                MessageBox.Show("Delivery Item Added!");
                //Audit
            }
            else
            {
                MessageBox.Show("Error adding Item!");
            }
        }
    }
}
