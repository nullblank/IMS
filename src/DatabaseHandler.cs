using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace IMS.DBHandler
{
    public class DatabaseHandler
    {
        private readonly string _connectionString;
        private SqlConnection _connection;
        public DatabaseHandler()
        {
            string server = ConfigurationManager.AppSettings["ServerName"];
            string database = ConfigurationManager.AppSettings["DatabaseName"];
            string username = ConfigurationManager.AppSettings["UserName"];
            string password = ConfigurationManager.AppSettings["Password"];
            _connectionString = $"Server={server};Database={database};User Id={username};Password={password};";
            _connection = new SqlConnection(_connectionString);
        }
        public bool OpenConnection() // Opens connection
        { 
            try
            {
                if (_connection.State == ConnectionState.Open) {}
                else
                {
                    _connection.Open();
                }
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error at OpenConnection: {ex.Message}");
                return false;
            }
        }
        public bool CloseConnection() // Closes connection
        {
            try
            {
                if (_connection.State == ConnectionState.Closed) { }
                else
                {
                    _connection.Close();
                }
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error at CloseConnection: {ex.Message}");
                return false;
            }
        }
        public void CheckConnection() //Checks Connection
        {
            try
            {
                _connection.Open();
                MessageBox.Show("Connection successful!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error at CheckConnection: " + ex.Message);
            }
            finally { CloseConnection(); }
        }
        public int ExecuteNonQuery(string query) // Returns no row
        {
            try
            {
                if (OpenConnection() == true)
                {
                    using (SqlCommand command = new SqlCommand(query, _connection))
                    {
                        int result = command.ExecuteNonQuery();
                        CloseConnection();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error at ExecuteNonQuery: {ex.Message}");
                return 0;
            }
            finally { CloseConnection(); }
        }
        public DataTable ExecuteQuery(string query) // Returns rows in the form of a datatable
        {
            try
            {
                OpenConnection();
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    CloseConnection();
                    return dataTable;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error at ExecuteQuery: {ex.Message}");
                return null;
            }
            finally { CloseConnection(); }
        }

        public SqlDataReader GetColumnData(string table, string column)
        {
            try
            {
                OpenConnection() ;
                using (SqlCommand command = new SqlCommand($"SELECT {column} FROM {table}", _connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    return reader;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error at GetColumnData: {ex.Message}");
                return null;
            }
        }

        public SqlDataReader GetActiveColumnData(string table, string column)
        {
            try
            {
                OpenConnection();
                using (SqlCommand command = new SqlCommand($"SELECT {column} FROM {table} WHERE isActive = '1'", _connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    return reader;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error at GetActiveColumnData: {ex.Message}");
                return null;
            }
        }
    }
}
