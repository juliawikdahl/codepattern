using Api_products.Factories;
using Api_products.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_products.Handlers
{

    // Jag har även använt mig av The Liskov Substitution Principle med hjälp utav vara interfaces. Det hjälper mig att förhindra modellhierarkier som inte överensstämmer med Open/Closed-principen.
    // Alla arvsmodeller som följer Liskov Substitutionsprincipen kommer att följa Open/Closed-principen.
    // objekt i en klass ska kunna ersättas med objekt av dess underklasser utan att applikationen bryts, vilket jag har byggt upp det med hjälp av våra interfaces.
    // Här har jag använt mig av Single Responsibility Principle då jag inte har gjort några instancer i denna fil utan jag gjorde en factory där alla mina instancer ligger,
    // alltså gör den här sidan bara en sak. 

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
