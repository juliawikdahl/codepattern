using Api_products.Models;

namespace Api_products.Factories
{
    public interface IProductFactory : IFactory
    {
        ProductEntity ProductEntity();
        Product Product(ProductEntity productEntity);

        List<Product> ProductList();
    }
}
