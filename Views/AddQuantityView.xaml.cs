using System.Windows;
using StockManagement.ViewModels;

namespace StockManagement.Views
{
    public partial class AddQuantityView : Window
    {
        public AddQuantityView(MainProgram mainProgramInstance)
        {
            InitializeComponent();
            DataContext = new AddQuantityViewModel(mainProgramInstance);
        }
    }
}