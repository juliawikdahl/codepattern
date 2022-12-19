namespace Api_products.Models
{
    public interface IProducts
    {
        ProductCategory Category { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
    }
    // Här använder jag Interface Segregation Principle och detta gör jag för att slippa dubbelkodning samt att man vet vad det kommer innehålla när man gör ett interface.
    // Man minskar biverkningarna och frekvensen av nödvändiga ändringar genom att dela upp programvaran i flera, oberoende delar.
}