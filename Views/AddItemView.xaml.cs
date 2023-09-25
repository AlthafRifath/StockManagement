using System.Windows;
using StockManagement.ViewModels;

namespace StockManagement.Views
{
    public partial class AddItemView : Window
    {
        public AddItemView(MainProgram mainProgramInstance)
        {
            InitializeComponent();
            DataContext = new AddItemViewModel(mainProgramInstance);
        }
    }
}