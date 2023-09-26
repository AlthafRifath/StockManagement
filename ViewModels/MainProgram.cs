using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows;
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
                string checkQuery = "SELECT COUNT(*) FROM stockitem WHERE StockCode = @StockCode";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@StockCode", stockItem.StockCode);
                connection.Open();
                object result = checkCommand.ExecuteScalar();
                if (Convert.ToInt32(result) > 0)
                {
                    MessageBox.Show("Duplicate stock code found!");
                    connection.Close();
                    return false;
                }
                
                string query = "INSERT INTO stockitem (StockCode, Name, QuantityInStock) VALUES (@StockCode, @Name, @QuantityInStock)";
                MySqlCommand command = new MySqlCommand(query, connection);
                
                command.Parameters.AddWithValue("@StockCode", stockItem.StockCode);
                command.Parameters.AddWithValue("@Name", stockItem.Name);
                command.Parameters.AddWithValue("@QuantityInStock", stockItem.Quantity);
                
                int rowsAffected = command.ExecuteNonQuery();
                
                // Debugging
                Console.WriteLine($"Preparing to insert StockCode: {stockItem.StockCode}, Name: {stockItem.Name}, Quantity: {stockItem.Quantity}");
                Console.WriteLine("Executing: " + command.CommandText);
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