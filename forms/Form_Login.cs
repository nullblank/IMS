using System.Configuration;
using System.Data;
using IMS.DBHandler;
using System.IO;
using System.Data.SqlClient;
using IMS.NetUtil;
using IMS.src;
using System.Security.Principal;
using System.Diagnostics;
using IMS.forms.update;
using System.Reflection;

namespace IMS
{
    public partial class Form_Login : Form
    {
        NetworkUtilities netutil = new NetworkUtilities();
        public Form_Login()
        {
            InitializeComponent();
        }
        static bool IsRunAsAdmin()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);

            // Check if the current user has administrative privileges
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        static void RunAsAdmin() //Unused
        {
            // Restart the application with admin privileges
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = Application.ExecutablePath;
            startInfo.Verb = "runas"; // Run with administrative privileges

            try
            {
                Process.Start(startInfo);
                Application.Exit(); // Exit the current instance of the application
            }
            catch (System.ComponentModel.Win32Exception)
            {
                // Handle the case when the user cancels the UAC prompt
                Console.WriteLine("User cancelled the UAC prompt.");
            }
        }
        private void button1_Click(object sender, EventArgs e) //Login
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            EncryptionHandler encrypt = new EncryptionHandler();
            pass = encrypt.Encrypt(pass);
            if (netutil.Login(user, pass))
            {
                if (!IsRunAsAdmin())
                {
                    var result = MessageBox.Show("This application needs to be run with administrative privileges. Reporting option has been DISABLED for Admin users.", "Admin Privileges Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.Hide();
            }
        }
        private void button2_Click(object sender, EventArgs e) //Check Connection
        {
            netutil.CheckConnection();
            DatabaseHandler handler = new DatabaseHandler();
            Audit audit = new Audit(handler);
            audit.LogAction("Connection Test");
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void Form_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            Form_Update form = new Form_Update(this);
            string currentVersion = Assembly.GetEntryAssembly().GetName().Version.ToString();
            gb1.Text = $"v{currentVersion}";
        }
    }
}