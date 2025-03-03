using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSystem.Model.PricingStrategies
{
    public abstract class PriceCalculatorDecorator : IPriceCalculator
    {
        protected IPriceCalculator calculator;

        public PriceCalculatorDecorator(IPriceCalculator calculator)
        {
            this.calculator = calculator;
        }

        public abstract string Name { get; }

        public virtual decimal CalculatePrice(decimal basePrice, int days, int hours)
        {
            return calculator.CalculatePrice(basePrice, days, hours);
        }
    }
}
