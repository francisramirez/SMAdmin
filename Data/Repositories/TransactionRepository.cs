using CoreBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Contracts;

namespace DataInMemory.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private List<Transaction> transactions;
        public TransactionRepository()
        {
            this.transactions = new List<Transaction>();

        }
        public IEnumerable<Transaction> GetByDay(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public void Save(string cashierName, int productId, decimal price, int quantity)
        {
            int transactionId = 0;

            if (this.transactions != null && this.transactions.Any())
            {
                int maxId = transactions.Max(tr => tr.TransactionId);
                transactionId = maxId + 1;
            }
            else
                transactionId = 1;

            this.transactions.Add(new Transaction()
            {
                CashierName = cashierName,
                Price = price,
                Quantity = quantity,
                ProductId = productId,
                TransactionDate = DateTime.Now
            });
        }
    }


}
