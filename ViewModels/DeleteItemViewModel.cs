using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using StockManagement.Models;

namespace StockManagement.ViewModels
{
    public class DeleteItemViewModel : INotifyPropertyChanged
    {
        public StockItem StockItem { get; set; }
        public ICommand DeleteItemCommand { get; set; }
        private MainProgram mainProgram;
        
        public DeleteItemViewModel(MainProgram mainProgramInstance)
        {
            StockItem = new StockItem("", "", 0);
            DeleteItemCommand = new RelayCommand(DeleteItem);
            mainProgram = mainProgramInstance;
        }
        
        private void DeleteItem()
        {
            Console.WriteLine("Stock Item: " + StockItem);
            Console.WriteLine("Stock Code: " + StockItem?.StockCode);
            bool wasSuccessful = mainProgram.DeleteItem(StockItem);
            ResultMessage = wasSuccessful ? "Item deleted successfully!" : "Item could not be deleted!";
        }
        
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
        
        public event PropertyChangedEventHandler PropertyChanged;
        
    }
}