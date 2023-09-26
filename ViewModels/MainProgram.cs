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
        
        public bool AddItem(Models.StockItem stockItem)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO stockitem (StockCode, Name, QuantityInStock) VALUES (@StockCode, @Name, @QuantityInStock)";
                MySqlCommand command = new MySqlCommand(query, connection);
                
                command.Parameters.AddWithValue("@StockCode", stockItem.StockCode);
                command.Parameters.AddWithValue("@Name", stockItem.Name);
                command.Parameters.AddWithValue("@QuantityInStock", stockItem.Quantity);
                
                // command.ExecuteNonQuery();
                
                // Debugging
                Console.WriteLine($"Preparing to insert StockCode: {stockItem.StockCode}, Name: {stockItem.Name}, Quantity: {stockItem.Quantity}");
                
                Console.WriteLine("Executing: " + command.CommandText);
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} rows affected");
                
                return rowsAffected > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
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