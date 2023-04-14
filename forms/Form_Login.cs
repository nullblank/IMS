using System.Configuration;
using System.Data;
using IMS.DBHandler;
using System.IO;
using System.Data.SqlClient;
using IMS.NetUtil;

namespace IMS
{
    public partial class Form_Login : Form
    {
        NetworkUtilities netutil = new NetworkUtilities();
        public Form_Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) //Login
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            if (netutil.Login(user, pass) == true)
            {
                this.Hide();
            }
        }
        private void button2_Click(object sender, EventArgs e) //Check Connection
        {
            netutil.CheckConnection();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string user = txtUsername.Text;
                string pass = txtPassword.Text;
                if (netutil.Login(user, pass) == true)
                {
                    this.Hide();
                }
            }
        }
    }
}