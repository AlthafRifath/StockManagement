using System.Configuration;
using MySql.Data.MySqlClient;

namespace StockManagement.Models
{
    public class DatabaseServices
    {
        private MySqlConnection connection;
        private string connectionString;
        
        public DatabaseServices()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            connection = new MySqlConnection(connectionString);
        }
    }
}