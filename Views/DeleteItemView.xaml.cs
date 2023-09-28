using System.Windows;
using StockManagement.ViewModels;

namespace StockManagement.Views
{
    public partial class DeleteItemView : Window
    {
        public DeleteItemView(MainProgram mainProgramInstance)
        {
            InitializeComponent();
            DataContext = new DeleteItemViewModel(mainProgramInstance);
        }
    }
}