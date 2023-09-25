using System.Windows;
using StockManagement.ViewModels;

namespace StockManagement.Views
{
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            MainProgram mainProgram = new MainProgram();
            DataContext = new ViewModels.MainViewModel(mainProgram);
        }
    }
}