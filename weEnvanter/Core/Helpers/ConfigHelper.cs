using System.Configuration;
using System.Data.SqlClient;

namespace weEnvanter.Core.Helpers
{
    public static class ConfigHelper
    {
        public static void UpdateConnectionString(string name, string connectionString)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");

            if (connectionStringsSection.ConnectionStrings[name] != null)
            {
                connectionStringsSection.ConnectionStrings[name].ConnectionString = connectionString;
            }
            else
            {
                connectionStringsSection.ConnectionStrings.Add(new ConnectionStringSettings(name, connectionString, "System.Data.SqlClient"));
            }

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
        public static bool TestConnection()
        {
            try
            {
                // App.config’ten connection string’i al
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["WeEnvanterConnection"].ConnectionString;

                // Timeout ekle (varsa üzerine yazar)
                if (!connectionString.ToLower().Contains("connect timeout"))
                {
                    connectionString += ";Connect Timeout=3;";
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static void EnsureDatabaseExists(string server, string database, string username, string password, bool windowsAuth)
        {
            // Sunucuya bağlanmak için master veritabanını kullan
            string masterConnStr;
            if (windowsAuth)
                masterConnStr = $"Server={server};Database=master;Trusted_Connection=True;Connect Timeout=3;";
            else
                masterConnStr = $"Server={server};Database=master;User Id={username};Password={password};Connect Timeout=3;";

            using (SqlConnection conn = new SqlConnection(masterConnStr))
            {
                conn.Open();
                string checkDbQuery = $"IF DB_ID('{database}') IS NULL CREATE DATABASE [{database}]";
                using (SqlCommand cmd = new SqlCommand(checkDbQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
