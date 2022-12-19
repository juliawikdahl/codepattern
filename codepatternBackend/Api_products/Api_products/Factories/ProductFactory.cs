using Api_products.Factories;
using Api_products.Models;

namespace Api_products
{
    public class ProductFactory : IProductFactory
    {
        public ProductEntity ProductEntity()
        {
            return new ProductEntity();
        }

        public Product Product(ProductEntity productEntity)
        {
            return new Product()
            {
                Id = productEntity.Id,
                Name = productEntity.Name,
                Price = productEntity.Price
            };
        }

        public List<Product> ProductList()
        {
            return new List<Product>();
        }
    }
}
