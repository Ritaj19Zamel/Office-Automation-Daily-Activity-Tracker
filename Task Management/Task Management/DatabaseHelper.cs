using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Task_Management
{
    class DatabaseHelper
    {
        private readonly string _connectionString = "data source= .;Integrated Security=true;Initial Catalog=Office_Automation_Daily_Activity_Tracker";

        public DatabaseHelper()
        {
            _connectionString = _connectionString;
        }
        // Method to execute a SQL command that does not return any results (e.g., INSERT, UPDATE, DELETE)
        public int ExeCommand(string sqlCommand)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // Method to execute a SQL command and return a single scalar value (e.g., COUNT, SUM)
        public object GetValue(string sqlCommand)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Method to execute a SQL command and return a DataTable
        public DataTable GetTable(string sqlCommand)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
