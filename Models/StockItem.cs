namespace StockManagement.Models
{
    public class StockItem
    {
        private string stockCode;
        private string name;
        private int quantity;
        
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        
        public StockItem(string stockCode, string name, int quantity)
        {
            StockCode = stockCode;
            Name = name;
            Quantity = quantity;
        }
    }
}