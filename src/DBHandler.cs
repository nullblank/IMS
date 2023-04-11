using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace IMS.Classes
{
    public class DBHandler
    {
        private readonly string _connectionString;
        private MySqlConnection _connection;

        public DBHandler(string server, string database, string uid, string password){
            /*
             * Replace placeholders
             */
            _connectionString = $"Server={server};Database={database};Uid={uid};Pwd={password};";
            _connection = new MySqlConnection(_connectionString);
        }

        public bool OpenConnection(){ // Opens connection
            try{
                _connection.Open();
                return true;
            }
            catch (MySqlException ex){
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public bool CloseConnection() // Closes connection
        {
            try{
                _connection.Close();
                return true;
            }
            catch (MySqlException ex){
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public int ExecuteNonQuery(string query) // Non-Query
        {
            if (OpenConnection() == true){
                using (MySqlCommand command = new MySqlCommand(query, _connection)){
                    int result = command.ExecuteNonQuery();
                    CloseConnection();
                    return result;
                }
            }
            else
            {
                return -1;
            }
        }

        public DataTable ExecuteQuery(string query) // Query
        {
            if (OpenConnection() == true){
                using (MySqlCommand command = new MySqlCommand(query, _connection)){
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command)){
                        dataAdapter.Fill(dataTable);
                    }
                    CloseConnection();
                    return dataTable;
                }
            }
            else
            {
                return null;
            }
        }

    }
}
