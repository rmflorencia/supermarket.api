namespace Supermarket.api.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public short QuantityinPackage { get; set; }

        public EUnitOfMeasurement UnitOfMeasurement { get; set; }

        public int CategoryId { get; set; } //will be used by the ORM 

        public Category Category { get; set; }

    }
}