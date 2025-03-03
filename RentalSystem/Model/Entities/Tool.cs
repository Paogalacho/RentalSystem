using RentalSystem.Model.PricingStrategies;

namespace RentalSystem.Model.Entities
{
    public class Tool : RentalItem
    {
        public string Category { get; }

        public Tool(string id, string name, string category, decimal basePrice, IPriceCalculator pricingStrategy)
            : base(id, name, basePrice, pricingStrategy)
        {
            Category = category;
        }
    }
}