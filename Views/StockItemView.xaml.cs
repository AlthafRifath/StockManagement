using System.Windows;

namespace StockManagement.Views
{
    public partial class StockItemView : Window
    {
        public StockItemView()
        {
            InitializeComponent();
            this.DataContext = new StockItemViewModel();
        }
    }
}