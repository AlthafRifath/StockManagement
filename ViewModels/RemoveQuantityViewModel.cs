using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using StockManagement.Models;

namespace StockManagement.ViewModels
{
    public class RemoveQuantityViewModel : INotifyPropertyChanged
    {
        public TransactionLog TransactionLog { get; set; }
        public ICommand RemoveQuantityCommand { get; set; }
        private MainProgram mainProgram;
        
        public RemoveQuantityViewModel(MainProgram mainProgram)
        {
            this.mainProgram = mainProgram;
            TransactionLog = new TransactionLog(default, "", "", "", 0, 0);
            RemoveQuantityCommand = new RelayCommand(RemoveQuantity);
        }
        
        private void RemoveQuantity()
        {
            bool wasSuccessful = mainProgram.RemoveQuantity(TransactionLog);
            ResultMessage = wasSuccessful ? "Quantity removed successfully!" : "Quantity could not be removed!";
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