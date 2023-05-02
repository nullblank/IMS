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

namespace IMS.forms.requests_resupply
{
    public partial class Requests : Form
    {
        DatabaseHandler _handler;
        SessionHandler _session;
        public Requests(DatabaseHandler handler, SessionHandler session)
        {
            _handler = handler;
            _session = session;
            lblUser.Text = _session.GetSessionUsername();
            lblRole.Text = _session.GetRole();
            lblOffice.Text = _session.GetOffice();
            InitializeComponent();
        }

        private void Requests_Load(object sender, EventArgs e)
        {

        }
    }
}
