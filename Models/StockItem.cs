using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StockManagement.Models
{
    public class StockItem : INotifyPropertyChanged
    {
        private string stockCode;
        private string name;
        private int quantity;
        
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
        
        public StockItem(string stockCode, string name, int quantity)
        {
            StockCode = stockCode;
            Name = name;
            Quantity = quantity;
        }
        
        public StockItem() {}

        public event PropertyChangedEventHandler PropertyChanged;
    }
}