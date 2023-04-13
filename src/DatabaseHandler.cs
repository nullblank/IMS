using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace IMS.DBHandler
{
    public class DatabaseHandler
    {
        private readonly string _connectionString;
        private SqlConnection _connection;

        public DatabaseHandler(string server, string database, string uid, string password)
        {
            /*
             * Replace placeholders
             */
            _connectionString = $"Server={server};Database={database};User Id={uid};Password={password};";
            _connection = new SqlConnection(_connectionString);
        }

        public bool OpenConnection()
        { // Opens connection
            try
            {
                _connection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
        public bool CloseConnection() // Closes connection
        {
            try
            {
                _connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public void CheckConnection()
        {
            try
            {
                _connection.Open();
                MessageBox.Show("Connection successful!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public int ExecuteNonQuery(string query) // Non-Query
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

        public DataTable ExecuteQuery(string query) // Query
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
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }

    }
}
