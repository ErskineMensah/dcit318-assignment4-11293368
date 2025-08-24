using System;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace MedicalBookingSystem
{
    public static class DatabaseHelper
    {
        public static string ConnectionString
        {
            get
            {
                var connectionStringSettings = ConfigurationManager.ConnectionStrings["MedicalDBConnection"];
                if (connectionStringSettings == null)
                {
                    throw new Exception("Connection string 'MedicalDBConnection' not found in App.config.");
                }
                return connectionStringSettings.ConnectionString;
            }
        }

        public static SqlConnection GetConnection()
        {
            var connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        public static int ExecuteNonQuery(string commandText, CommandType commandType = CommandType.Text, params SqlParameter[] parameters)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand(commandText, connection))
            {
                command.CommandType = commandType;
                command.Parameters.AddRange(parameters);

                return command.ExecuteNonQuery();
            }
        }

        public static DataTable GetDataTable(string commandText, CommandType commandType = CommandType.Text, params SqlParameter[] parameters)
        {
            var dataTable = new DataTable();

            using (var connection = GetConnection())
            using (var command = new SqlCommand(commandText, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                command.CommandType = commandType;
                command.Parameters.AddRange(parameters);

                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        public static SqlDataReader ExecuteReader(string commandText, CommandType commandType = CommandType.Text, params SqlParameter[] parameters)
        {
            var connection = GetConnection(); 
            var command = new SqlCommand(commandText, connection);
            command.CommandType = commandType;
            command.Parameters.AddRange(parameters);

            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}