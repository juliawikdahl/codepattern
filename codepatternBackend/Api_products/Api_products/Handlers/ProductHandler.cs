using Api_products.Factories;
using Api_products.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_products.Handlers
{
    public class ProductHandler : IProductHandler
    {
        private readonly Sqlcontext _sql;
        private readonly IProductFactory _factory;

        public ProductHandler(Sqlcontext sql, IProductFactory factory)
        {
            _sql = sql;
            _factory = factory;
        }

        public async Task CreateAsync(ProductModel model)
        {
            var productentity = _factory.ProductEntity();

            productentity.Name = model.Name;
            productentity.Price = model.Price;
            productentity.Category = model.Category;

            _sql.Add(productentity);
            await _sql.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            List<Product> products = _factory.ProductList();
            foreach (var productentity in await _sql.Products.ToListAsync())
                products.Add(_factory.Product(productentity));
            return products;
        }

        public Task<ProductEntity> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

      
    }
}
