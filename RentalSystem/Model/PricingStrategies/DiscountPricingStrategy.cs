using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSystem.Model.PricingStrategies
{
    public class DiscountPricingStrategy : PriceCalculatorDecorator
    {
        private readonly decimal discountPercentage;

        public DiscountPricingStrategy(IPriceCalculator calculator, decimal discountPercentage)
            : base(calculator)
        {
            this.discountPercentage = discountPercentage;
        }

        public override string Name => $"{calculator.Name} with {discountPercentage:P0} Discount";

        public override decimal CalculatePrice(decimal basePrice, int days, int hours)
        {
            decimal price = base.CalculatePrice(basePrice, days, hours);
            return price * (1 - discountPercentage);
        }
    }
}
