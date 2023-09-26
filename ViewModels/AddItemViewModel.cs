using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using StockManagement.Models;

namespace StockManagement.ViewModels
{
    public class AddItemViewModel : INotifyPropertyChanged
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
            bool wasSuccessful = mainProgram.AddItem(StockItem);
            ResultMessage = wasSuccessful ? "Item added successfully!" : "Item could not be added!";
        }
        
        private bool CanAddItem()
        {
            return !string.IsNullOrEmpty(StockItem.StockCode) && !string.IsNullOrEmpty(StockItem.Name) && StockItem.Quantity > 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private string resultMessage;

        public string ResultMessage
        {
            get { return resultMessage; }
            set
            {
                if (resultMessage != value)
                {
                    resultMessage = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ResultMessage)));
                }
            }
        }
    }
}