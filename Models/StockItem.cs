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

        public event PropertyChangedEventHandler PropertyChanged;
    }
    // {
    //     private string stockCode;
    //     private string name;
    //     private int quantity;
    //     
    //     public string StockCode
    //     {
    //         get { return stockCode; }
    //         set { stockCode = value; }
    //     }
    //     
    //     public string Name
    //     {
    //         get { return name; }
    //         set { name = value; }
    //     }
    //     
    //     public int Quantity
    //     {
    //         get { return quantity; }
    //         set { quantity = value; }
    //     }
    //     
    //     public StockItem(string stockCode, string name, int quantity)
    //     {
    //         StockCode = stockCode;
    //         Name = name;
    //         Quantity = quantity;
    //     }
    //
    //     public event PropertyChangedEventHandler PropertyChanged;
    //
    //     protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    //     {
    //         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //     }
    //
    //     protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
    //     {
    //         if (EqualityComparer<T>.Default.Equals(field, value)) return false;
    //         field = value;
    //         OnPropertyChanged(propertyName);
    //         return true;
    //     }
    // }
}