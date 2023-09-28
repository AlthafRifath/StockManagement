using System.Windows;
using StockManagement.ViewModels;

namespace StockManagement.Views
{
    public partial class ViewStockLevelsView : Window
    {
        public ViewStockLevelsView(MainProgram mainProgramInstance)
        {
            InitializeComponent();
            DataContext = new ViewStockLevelsModel(mainProgramInstance);
        }
    }
}