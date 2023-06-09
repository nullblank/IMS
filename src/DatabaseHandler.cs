﻿using System;
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
    /*
     * Dance with me under the diamonds
     * See me like breath in the cold
     * Sleep with me here in the silence
     * Come kiss me, silver and gold.
     * 
     * You say that I won't lose you
     * But you can't predict the future
     * So just hold on like you will never let go
     * Yeah, if you ever move on without me
     * I need to make sure you know
     * 
     * That you
     * Are the only one I'll ever love
     * ~
     * Yeah, you,
     * if it's not you, it's not anyone
     * ~
     * Lookin' back on my life, you're the only good I've ever done
     * ~
     * Yeah, you,
     * if it's not you, it's not anyone
     * ~ Not anyone.
     */
    public class DatabaseHandler
    {
        private readonly string _connectionString;
        private SqlConnection _connection;
        public DatabaseHandler()
        {
            Form_Login form = new Form_Login();
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
        //==================================================================================================
        //==================================================================================================
        //==================================================================================================
        //==================================================================================================
        //==================================================================================================
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

        public SqlDataReader GetTableData(string table)
        {
            try
            {
                OpenConnection();
                using (SqlCommand command = new SqlCommand($"SELECT * FROM {table}", _connection))
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

        public int GetColumnCode(string table, string column, string description)
        {
            try
            {
                OpenConnection();
                using (SqlCommand command = new SqlCommand($"SELECT * FROM {table} WHERE {column} = '{description}'", _connection))
                {
                    int result;
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        result = reader.GetInt32(1);
                        return result;
                    }
                    reader.Close();
                }
                return 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error at GetColumnData: {ex.Message}");
                return 0;
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

        public SqlDataReader GetCode(string table, string category, string scategory)
        {
            try
            {
                OpenConnection();
                if (String.IsNullOrEmpty(scategory))
                {
                    using (SqlCommand command = new SqlCommand($"SELECT * FROM {table} WHERE SITE_SCAT = '{category}'", _connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        return reader;
                    }
                }
                else
                {
                    using (SqlCommand command = new SqlCommand($"SELECT * FROM {table} WHERE SITE_SCAT = '{category}' AND SITE_SCA = '{scategory}'", _connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        return reader;
                    }
                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error at GetCode: {ex.Message}");
                return null;
            }
        }

        public SqlDataReader GetItemCode(string table, string column, string itemName)
        {
            try
            {
                OpenConnection();
                using (SqlCommand command = new SqlCommand($"SELECT {column} FROM {table} WHERE SITE_DES = '{itemName}'", _connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    return reader;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error at GetCode: {ex.Message}");
                return null;
            }
        }


    }
}
