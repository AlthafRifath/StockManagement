using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using StockManagement.Models;

namespace StockManagement.ViewModels
{
    public class TransactionLogViewModel : INotifyPropertyChanged
    {
        private readonly MainProgram mainProgram;

        private ObservableCollection<TransactionLog> transactionLogs;
        public ObservableCollection<TransactionLog> TransactionLogs 
        {
            get { return transactionLogs; }
            set
            {
                if (transactionLogs != value)
                {
                    transactionLogs = value;
                    OnPropertyChanged(nameof(TransactionLogs));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public TransactionLogViewModel(MainProgram mainProgram)
        {
            this.mainProgram = mainProgram;
            TransactionLogs = new ObservableCollection<TransactionLog>(); 
            RefreshData();
        }

        public void RefreshData()
        {
            TransactionLogs.Clear(); 
            
            var logs = mainProgram.FetchTransactionLogs();
            foreach (var log in logs)
            {
                TransactionLogs.Add(log);
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}