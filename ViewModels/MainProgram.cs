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
            try
            {
                connection.Open();
                string query = "INSERT INTO stockitem (stockCode, Name, QuantityInStock) VALUES (@stockCode, @description, @quantity)";
                MySqlCommand command = new MySqlCommand(query, connection);
                
                command.Parameters.AddWithValue("@stockCode", item.getStockCode());
                command.Parameters.AddWithValue("@description", item.getName());
                command.Parameters.AddWithValue("@quantity", item.getQuantity());
                
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                connection.Close();
            }
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