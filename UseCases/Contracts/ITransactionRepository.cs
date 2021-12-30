using System;
using System.Collections.Generic;
using CoreBusiness.Entities;


namespace UseCases.Contracts
{
    public interface ITransactionRepository
    {
        public void Save(string cashierName, int productId, decimal price, int quantity);
        public IEnumerable<Transaction> GetByDay(DateTime startDate, DateTime endDate);
    }
}
