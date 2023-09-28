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
                
                string query1 = "INSERT INTO stockitem (StockCode, Name, QuantityInStock) VALUES (@StockCode, @Name, @QuantityInStock)";
                MySqlCommand command1 = new MySqlCommand(query1, connection);
                command1.Parameters.AddWithValue("@StockCode", stockItem.StockCode);
                command1.Parameters.AddWithValue("@Name", stockItem.Name);
                command1.Parameters.AddWithValue("@QuantityInStock", stockItem.Quantity);
                int rowsAffected1 = command1.ExecuteNonQuery();
                
                string query2 = "INSERT INTO transactionlogs (DateTime, StockCode, StockItemName, QuantityChange) VALUES (NOW(), @StockCode, @StockItemName, @QuantityChange)";
                MySqlCommand command2 = new MySqlCommand(query2, connection);
                command2.Parameters.AddWithValue("@StockCode", stockItem.StockCode);
                command2.Parameters.AddWithValue("@StockItemName", stockItem.Name);
                command2.Parameters.AddWithValue("@QuantityChange", stockItem.Quantity);
                int rowsAffected2 = command2.ExecuteNonQuery();
                
                // Debugging
                Console.WriteLine($"Preparing to insert StockCode: {stockItem.StockCode}, Name: {stockItem.Name}, Quantity: {stockItem.Quantity}");
                Console.WriteLine("Executing: " + command1.CommandText);
                Console.WriteLine($"{rowsAffected1} rows affected in stockitem table");
                Console.WriteLine("Executing: " + command2.CommandText);
                Console.WriteLine($"{rowsAffected2} rows affected in transactionlogs table");
                
                return rowsAffected1 > 0 && rowsAffected2 > 0;
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

        public bool AddQuantity(Models.TransactionLog transactionLog)
        {
            try
            {
                string checkQuery = "SELECT COUNT(*) FROM stockitem WHERE StockCode = @StockCode";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@StockCode", transactionLog.StockCode);
                connection.Open();
                object result = checkCommand.ExecuteScalar();
                if (Convert.ToInt32(result) == 0)
                {
                    MessageBox.Show("Stock code not found!");
                    connection.Close();
                    return false;
                }

                string query = "UPDATE transactionlogs SET DateTime = NOW(), QuantityChange = QuantityChange + @QuantityChange WHERE StockCode = @StockCode";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@StockCode", transactionLog.StockCode);
                command.Parameters.AddWithValue("@QuantityChange", transactionLog.Quantity);

                int rowsAffected = command.ExecuteNonQuery();

                // Debugging
                Console.WriteLine($"Preparing to insert StockCode: {transactionLog.StockCode}, Name: {transactionLog.Name}, Quantity: {transactionLog.Quantity}");
                Console.WriteLine("Executing: " + command.CommandText);
                Console.WriteLine($"{rowsAffected} rows affected");

                if (rowsAffected > 0)
                {
                    string updateQuery = "UPDATE stockitem SET QuantityInStock = QuantityInStock + @Quantity WHERE StockCode = @StockCode";
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@Quantity", transactionLog.Quantity);
                    updateCommand.Parameters.AddWithValue("@StockCode", transactionLog.StockCode);
                    int updateRowsAffected = updateCommand.ExecuteNonQuery();
                
                    // Debugging
                    Console.WriteLine($"Preparing to update StockCode: {transactionLog.StockCode}, Quantity: {transactionLog.Quantity}");
                    Console.WriteLine("Executing: " + updateCommand.CommandText);
                    Console.WriteLine($"{updateRowsAffected} rows affected");
                }
                return true;
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