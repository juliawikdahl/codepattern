namespace Api_products.Models
{
    public interface IProducts
    {
        ProductCategory Category { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
    }
}