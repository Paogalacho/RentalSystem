namespace RentalSystem.Model.PricingStrategies
{
    public interface IPriceCalculator
    {
        string Name { get; }
        decimal CalculatePrice(decimal basePrice, int days, int hours);
    }

}

