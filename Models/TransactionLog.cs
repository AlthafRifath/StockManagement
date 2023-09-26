using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StockManagement.Models
{
    public class TransactionLog : INotifyPropertyChanged
    {
        private DateTime date;
        private string transactionType;
        private string stockCode;
        private string name;
        private int quantity;
        private int newQuantity;

        public DateTime Date
        {
            get { return date; }
            set
            {
                if (date != value)
                {
                    date = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Date)));
                }
            }
        }
        
        public string TransactionType
        {
            get { return transactionType; }
            set
            {
                if (transactionType != value)
                {
                    transactionType = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TransactionType)));
                }
            }
        }
        
        public string StockCode
        {
            get { return stockCode; }
            set
            {
                if (stockCode != value)
                {
                    stockCode = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StockCode)));
                }
            }
        }
        
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
                }
            }
        }
        
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (quantity != value)
                {
                    quantity = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Quantity)));
                }
            }
        }
        
        public int NewQuantity
        {
            get { return newQuantity; }
            set
            {
                if (newQuantity != value)
                {
                    newQuantity = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NewQuantity)));
                }
            }
        }
        
        public TransactionLog(DateTime date, string transactionType, string stockCode, string name, int quantity, int newQuantity)
        {
            Date = date;
            TransactionType = transactionType;
            StockCode = stockCode;
            Name = name;
            Quantity = quantity;
            NewQuantity = newQuantity;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}