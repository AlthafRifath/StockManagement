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
        
        public DateTime GetDate()
        {
            return date;
        }
        
        public string GetTransactionType()
        {
            return transactionType;
        }
        
        public string GetStockCode()
        {
            return stockCode;
        }
        
        public string GetName()
        {
            return name;
        }
        
        public int GetQuantity()
        {
            return quantity;
        }
        
        public int GetNewQuantity()
        {
            return newQuantity;
        }
        
        public TransactionLog(DateTime date, string transactionType, string stockCode, string name, int quantity, int newQuantity)
        {
            this.date = date;
            this.transactionType = transactionType;
            this.stockCode = stockCode;
            this.name = name;
            this.quantity = quantity;
            this.newQuantity = newQuantity;
        }
    }
}