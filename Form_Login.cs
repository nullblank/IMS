using System.Configuration;
using System.Data;
using IMS.DBHandler;
using System.IO;

namespace IMS
{
    public partial class Form_Login : Form
    {
        string server = ConfigurationManager.AppSettings["ServerName"];
        string database = ConfigurationManager.AppSettings["DatabaseName"];
        string username = ConfigurationManager.AppSettings["UserName"];
        string password = ConfigurationManager.AppSettings["Password"];
        DatabaseHandler handler;
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Server: {server} | Database: {database} | Username: {username} | Password: {password}" );// Debug
            handler = new DatabaseHandler(server, database, username, password);// Debug
            DataTable dataTable = handler.ExecuteQuery("SELECT * FROM MyTable");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            handler = new DatabaseHandler(server, database, username, password);//Debug
            DataTable dataTable = handler.ExecuteQuery("SELECT * FROM MyTable");
        }
    }
}