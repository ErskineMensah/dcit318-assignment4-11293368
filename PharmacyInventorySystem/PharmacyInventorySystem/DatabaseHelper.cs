using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace PharmacyManagementSystem
{
    public partial class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper()
        {
            // Safe way to get connection string
            var connectionStringSettings = ConfigurationManager.ConnectionStrings["PharmacyDBConnection"];
            if (connectionStringSettings == null)
            {
                throw new InvalidOperationException("PharmacyDBConnection not found in App.config. Please check your configuration.");
            }

            connectionString = connectionStringSettings.ConnectionString;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}