using MySql.Data.MySqlClient;
using System;
using System.Data;
namespace StockManagement.Models
{
    public class MainProgram
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;user=root;database=stockmanagementdb;port=3306;password=1100";
        
        public MainProgram()
        {
            connection = new MySqlConnection(connectionString);
        }
        
        public void AddItem(StockItem item)
        {
            
        }
        
        public void AddQuantity(string stockCode, int quantity)
        {
            
        }
        
        public void RemoveQuantity(string stockCode, int quantity)
        {
            
        }
        
        public void DeleteItem(string stockCode)
        {
            
        }
        
        public void ViewTransactionLog()
        {
            
        }
        
        public void ViewStockLevels()
        {
            
        }
    }
}