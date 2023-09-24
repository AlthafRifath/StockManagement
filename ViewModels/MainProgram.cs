using MySql.Data.MySqlClient;
using System;
using System.Data;
using StockManagement.Models;

namespace StockManagement.ViewModels
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
            StockItem stockItem = new StockItem("1234", "Test Item", 10);
               
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