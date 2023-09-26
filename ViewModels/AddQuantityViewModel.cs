using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using StockManagement.Models;

namespace StockManagement.ViewModels
{
    public class AddQuantityViewModel : INotifyPropertyChanged
    {
        public TransactionLog TransactionLog { get; set; }
        public ICommand AddQuantityCommand { get; set; }
        private MainProgram mainProgram;
        
        public AddQuantityViewModel(MainProgram mainProgram)
        {
            this.mainProgram = mainProgram;
            TransactionLog = new TransactionLog(default, "", "", "", 0, 0);
            AddQuantityCommand = new RelayCommand(AddQuantity);
        }
        
        private void AddQuantity()
        {
            bool wasSuccessful = mainProgram.AddQuantity(TransactionLog);
            ResultMessage = wasSuccessful ? "Quantity added successfully!" : "Quantity could not be added!";
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