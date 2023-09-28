using System.Windows;
using StockManagement.ViewModels;

namespace StockManagement.Views
{
    public partial class TransactionLogView : Window
    {
        public TransactionLogView(MainProgram mainProgramInstance)
        {
            InitializeComponent();
            DataContext = new TransactionLogViewModel(mainProgramInstance);
        }
    }
}