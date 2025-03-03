using RentalSystem.Model.Entities;
using RentalSystem.Model.PricingStrategies;

public class Vehicle : RentalItem
{
    public string Model { get; }

    public Vehicle(string id, string name, string model, decimal basePrice, IPriceCalculator pricingStrategy)
        : base(id, name, basePrice, pricingStrategy)
    {
        Model = model;
    }
}