using RentalSystem.Model.Entities;
using RentalSystem.Model.PricingStrategies;

namespace RentalSystem.Model.Factories
{
    public class VehicleFactory
    {
        public RentalItem CreateRentalItem(string id, string name, string model, decimal basePrice)
        {
            return new Vehicle(id, name, model, basePrice, new StandardPricingStrategy());
        }
    }
}