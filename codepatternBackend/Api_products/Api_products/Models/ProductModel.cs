namespace Api_products.Models
{
    public class ProductModel
    {
        public string Name { get; set; } = null!;
        public ProductCategory Category { get; set; }
        public decimal Price { get; set; }
    }
}
