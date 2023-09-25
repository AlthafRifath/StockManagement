using System;

namespace StockManagement.Models
{
    public class TransactionLog
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
            set { date = value; }
        }
        
        public string TransactionType
        {
            get { return transactionType; }
            set { transactionType = value; }
        }
        
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
        
        public int NewQuantity
        {
            get { return newQuantity; }
            set { newQuantity = value; }
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
    }
}