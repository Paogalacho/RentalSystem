using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSystem.Model.PricingStrategies
{
    public class WeeklyDiscountStrategy : PriceCalculatorDecorator
    {
        private readonly int daysForDiscount;
        private readonly decimal discountPercentage;

        public WeeklyDiscountStrategy(IPriceCalculator calculator, int daysForDiscount, decimal discountPercentage)
            : base(calculator)
        {
            this.daysForDiscount = daysForDiscount;
            this.discountPercentage = discountPercentage;
        }

        public override string Name => $"{calculator.Name} with Weekly Discount";

        public override decimal CalculatePrice(decimal basePrice, int days, int hours)
        {
            decimal price = base.CalculatePrice(basePrice, days, hours);
            int weeks = days / daysForDiscount;
            if (weeks > 0)
            {
                decimal discount = price * discountPercentage * weeks;
                price -= discount;
            }
            return price;
        }
    }
}
