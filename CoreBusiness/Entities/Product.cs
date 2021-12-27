using System.ComponentModel.DataAnnotations;
namespace CoreBusiness.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public int SupplierId { get; set; }
        
        [Required]
        public int CategoryId { get; set; }
        
        [Required]
        public decimal UnitPrice { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public bool Discontinued { get; set; }
    }
}
