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
        
        public void AddItem(Models.StockItem stockItem)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO stockitem (StockCode, Name, QuantityInStock) VALUES (@StockCode, @Name, @QuantityInStock)";
                MySqlCommand command = new MySqlCommand(query, connection);
                
                command.Parameters.AddWithValue("@StockCode", stockItem.getStockCode());
                command.Parameters.AddWithValue("@Name", stockItem.getName());
                command.Parameters.AddWithValue("@QuantityInStock", stockItem.getQuantity());
                
                // command.ExecuteNonQuery();
                
                Console.WriteLine($"Preparing to insert StockCode: {stockItem.getStockCode()}, Name: {stockItem.getName()}, Quantity: {stockItem.getQuantity()}");
                
                Console.WriteLine("Executing: " + command.CommandText);
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} rows affected");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
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