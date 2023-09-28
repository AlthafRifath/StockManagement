using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using StockManagement.Models;

namespace StockManagement.ViewModels
{
    public class ViewStockLevelsModel : INotifyPropertyChanged
    {
        private readonly MainProgram mainProgram;
        
        private ObservableCollection<StockItem> stockItems;
        public ObservableCollection<StockItem> StockItems
        {
            get { return stockItems; }
            set
            {
                if (stockItems != value)
                {
                    stockItems = value;
                    OnPropertyChanged(nameof(StockItems));
                }
            }
        }
        
        public ViewStockLevelsModel(MainProgram mainProgram)
        {
            this.mainProgram = mainProgram;
            StockItems = new ObservableCollection<StockItem>();
            RefreshData();
        }
        
        public void RefreshData()
        {
            StockItems.Clear();
            
            var items = mainProgram.FetchStockLevels();
            foreach (var item in items)
            {
                StockItems.Add(item);
            }
        }
        
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
    }
}