using RentalSystem.Model.PricingStrategies;

namespace RentalSystem.Model.Entities
{
    public abstract class RentalItem
    {
        public string Id { get; }
        public string Name { get; }
        public bool IsAvailable { get; private set; }
        public decimal BasePrice { get; set; }
        protected IPriceCalculator PricingStrategy { get; set; }

        protected RentalItem(string id, string name, decimal basePrice, IPriceCalculator pricingStrategy)
        {
            Id = id;
            Name = name;
            BasePrice = basePrice;
            IsAvailable = true;
            PricingStrategy = pricingStrategy;
        }

        public decimal CalculateRentalCost(int days, int hours)
        {
            return PricingStrategy.CalculatePrice(BasePrice, days, hours);
        }

        public void Rent()
        {
            if (!IsAvailable)
                throw new InvalidOperationException("Item is not available for rent.");
            IsAvailable = false;
        }

        public void Return()
        {
            IsAvailable = true;
        }

        public void SetPricingStrategy(IPriceCalculator pricingStrategy)
        {
            PricingStrategy = pricingStrategy;
        }
    }

}