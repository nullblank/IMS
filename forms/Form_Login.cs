using System.Configuration;
using System.Data;
using IMS.DBHandler;
using System.IO;
using System.Data.SqlClient;

namespace IMS
{
    public partial class Form_Login : Form
    {
        //Global Variables
        string server = ConfigurationManager.AppSettings["ServerName"];
        string database = ConfigurationManager.AppSettings["DatabaseName"];
        string username = ConfigurationManager.AppSettings["UserName"];
        string password = ConfigurationManager.AppSettings["Password"];
        DatabaseHandler handler;
        public Form_Login()
        {
            InitializeComponent();
        }
        //Element Methods
        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            login(user, pass);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            handler = new DatabaseHandler(server, database, username, password);//Debug
            handler.CheckConnection();
        }
        //Methods
        private void login(string user, string pass)
        {
            try
            {
                handler = new DatabaseHandler(server, database, username, password); //initialize connection
                if (handler != null)
                {
                    DataTable results = handler.ExecuteQuery($"SELECT COUNT(*) FROM IMS_USR WHERE USR_NME COLLATE Latin1_General_CS_AS = '{user}' AND USR_PWD COLLATE Latin1_General_CS_AS = '{pass}'");
                    if (results != null && (int)results.Rows[0][0] > 0)
                    {
                        MessageBox.Show("Login Successful!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login!");
                    }
                }
                else
                {
                    MessageBox.Show("Database connection not initialized.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}