using RentalSystem.Model.Entities;
using RentalSystem.Model.PricingStrategies;

namespace RentalSystem.Model.Factories
{
    public class ToolFactory
    {
        public RentalItem CreateRentalItem(string id, string name, string category, decimal basePrice)
        {
            return new Tool(id, name, category, basePrice, new StandardPricingStrategy());
        }
    }
}