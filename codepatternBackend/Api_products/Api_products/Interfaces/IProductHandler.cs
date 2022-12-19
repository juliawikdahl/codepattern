using Api_products.Models;

namespace Api_products
{
    public interface IProductHandler
    {
        Task CreateAsync(ProductModel model);
        Task<IEnumerable<Product>> GetAllAsync();
        Task <ProductEntity> GetAsync(int id);
    }
}
