using Api_products.Models;

namespace Api_products
{
    public interface IProductHandler
    {
        Task CreateAsync(ProductModel model);
        Task<IEnumerable<Product>> GetAllAsync();
        Task <ProductEntity> GetAsync(int id);
    }
    // Här använder jag Interface Segregation Principle och detta gör jag för att slippa dubbelkodning samt att man vet vad det kommer innehålla när man gör ett interface.
    // Man minskar biverkningarna och frekvensen av nödvändiga ändringar genom att dela upp programvaran i flera, oberoende delar.


}
