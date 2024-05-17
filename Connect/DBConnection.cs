using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace TestProject.Connect
{
    public class DBConnection : IDisposable
    {
        private SqlConnection connection;
        private string connectionString;
        public DBConnection(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new SqlConnection(this.connectionString);
        }

        public void Open()
        {
            connection.Open();
            Console.WriteLine("Connection opened successfully.");
        }

        public void Close()
        {
            connection.Close();
            Console.WriteLine("Connection closed successfully.");
        }

        public List<string> GetFieldNames(string tableName)
        {
            List<string> fieldNames = new List<string>();
            string query = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}'";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string columnName = reader["COLUMN_NAME"].ToString();
                    fieldNames.Add(columnName);
                }
                reader.Close();
            }
            return fieldNames;
        }

        public DataTable GetDataTable(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
            }
            return dataTable;
        }

        public void Query(string query)
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void Query(string query, List<SqlParameter> parameters = null)
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters.ToArray());
                }
                command.ExecuteNonQuery();
            }
        }

        public void Dispose()
        {
            Close();
        }
    }
}
