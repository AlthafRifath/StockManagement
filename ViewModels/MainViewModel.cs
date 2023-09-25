using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using StockManagement.Views;

namespace StockManagement.ViewModels
{
    public class MainViewModel
    {
        public ICommand AddItemCommand { get; set; }
        public ICommand AddQuantityCommand { get; set; }
        public ICommand RemoveQuantityCommand { get; set; }
        public ICommand DeleteItemCommand { get; set; }
        public ICommand ViewTransactionLogCommand { get; set; }
        public ICommand ViewStockLevelsCommand { get; set; }
        
        private MainProgram mainProgram;

        public MainViewModel(MainProgram mainProgramInstance)
        {
            mainProgram = mainProgramInstance;
            
            AddItemCommand = new RelayCommand(OpenAddItemView);
            AddQuantityCommand = new RelayCommand(OpenAddQuantityView);
            RemoveQuantityCommand = new RelayCommand(OpenRemoveQuantityView);
            DeleteItemCommand = new RelayCommand(OpenDeleteItemView);
            ViewTransactionLogCommand = new RelayCommand(OpenViewTransactionLogView);
            ViewStockLevelsCommand = new RelayCommand(OpenViewStockLevelsView);
        }
        
        private void OpenAddItemView()
        {
            AddItemView addItemView = new AddItemView(mainProgram);
            addItemView.Show();
        }
        
        private void OpenAddQuantityView()
        {
            AddQuantityView addQuantityView = new AddQuantityView();
            addQuantityView.Show();
        }
        
        private void OpenRemoveQuantityView()
        {
            RemoveQuantityView removeQuantityView = new RemoveQuantityView();
            removeQuantityView.Show();
        }
        
        private void OpenDeleteItemView()
        {
            DeleteItemView deleteItemView = new DeleteItemView();
            deleteItemView.Show();
        }
        
        private void OpenViewTransactionLogView()
        {
            
        }
        private void OpenViewStockLevelsView()
        {
            ViewStockLevelsView viewStockLevelsView = new ViewStockLevelsView();
            viewStockLevelsView.Show();
        }
    }
}