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
        
        public StockItem(string stockCode, string name, int quantity)
        {
            this.stockCode = stockCode;
            this.name = name;
            this.quantity = quantity;
        }
    }
}