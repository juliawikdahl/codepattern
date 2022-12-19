using System.ComponentModel.DataAnnotations;

namespace Api_products.Models
{
    public class ProductEntity : IProducts

    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ProductCategory Category { get; set; }
        public decimal Price { get; set; }

    }
}
