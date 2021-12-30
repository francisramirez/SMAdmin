namespace UseCases.Models
{
    public class RecordTransactionModel
    {
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string CashierName { get; set; }

    }
}
