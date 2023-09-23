using System;
using System.Windows;
using MySql.Data.MySqlClient;
using StockManagement.Models;
using System.Data;

namespace StockManagement.Views
{
    public partial class AdminView : Window
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;user=root;database=stockmanagementdb;port=3306;password=1100";

        public AdminView()
        {
            InitializeComponent(); // initialize the components of the window (designer code) 
            connection = new MySqlConnection(connectionString);
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                LoginResultText.Text = "Please enter username and password!";
            }
            else
            {
                // A parameterized query to prevent SQL injection
                string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Parameters to the query
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                try
                { 
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        MainView mainView = new MainView();
                        mainView.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}