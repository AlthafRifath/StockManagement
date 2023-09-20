namespace StockManagement.Models
{
    public class StockItem
    {
        private string stockCode;
        private string name;
        private int quantity;
        
        public string getStockCode()
        {
            return stockCode;
        }
        
        public string getName()
        {
            return name;
        }
        
        public int getQuantity()
        {
            return quantity;
        }
    }
}