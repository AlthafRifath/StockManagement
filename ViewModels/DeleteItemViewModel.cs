using System;
using System.ComponentModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using StockManagement.Models;

namespace StockManagement.ViewModels
{
    public class DeleteItemViewModel : INotifyPropertyChanging
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
                    PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(nameof(ResultMessage)));
                }
            }
        }
        
        public event PropertyChangingEventHandler PropertyChanging;
    }
}