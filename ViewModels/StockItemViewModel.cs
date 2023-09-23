using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using StockManagement.Models;

namespace StockManagement.Views
{
    public class StockItemViewModel
    {
        public StockItem StockItem { get; set; }
        public ICommand AddItemCommand { get; set; }
        
        public StockItemViewModel()
        {
            StockItem = new StockItem("", "", 0);
            AddItemCommand = new RelayCommand(AddItem);
        }
        
        private void AddItem()
        {
            MainProgram mainProgram = new MainProgram();
            mainProgram.AddItem(StockItem);
        }
    }
}