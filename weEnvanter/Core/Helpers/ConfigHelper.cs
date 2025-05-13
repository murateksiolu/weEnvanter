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
    }
}
