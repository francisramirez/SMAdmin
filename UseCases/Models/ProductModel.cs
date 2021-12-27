namespace UseCases.Models
{
    public class ProductListModel
    {
        public int  ProductId { get; set; }
        public string Name { get; set; }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public bool Discontinued { get; set; }

    }
}
