using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using StockManagement.Models;

namespace StockManagement.ViewModels
{
    public class AddItemViewModel
    {
        public StockItem StockItem {get; set;}
        public ICommand AddItemCommand {get; set;}
        
        private MainProgram mainProgram;

        public AddItemViewModel(MainProgram mainProgramInstance)
        {
            StockItem = new StockItem("", "", 0);
            AddItemCommand = new RelayCommand(AddItem);
            mainProgram = mainProgramInstance;
        }
        
        private void AddItem()
        {
            mainProgram.AddItem(StockItem);
        }
    }
}