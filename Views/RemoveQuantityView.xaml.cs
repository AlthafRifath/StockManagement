using System.Windows;
using StockManagement.ViewModels;

namespace StockManagement.Views
{
    public partial class RemoveQuantityView : Window
    {
        public RemoveQuantityView(MainProgram mainProgramInstance)
        {
            InitializeComponent();
            DataContext = new RemoveQuantityViewModel(mainProgramInstance);
        }
    }
}