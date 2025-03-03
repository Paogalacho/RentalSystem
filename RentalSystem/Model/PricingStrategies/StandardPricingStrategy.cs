using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSystem.Model.PricingStrategies
{
    public class StandardPricingStrategy : IPriceCalculator
    {
        public string Name => "Standard";

        public decimal CalculatePrice(decimal basePrice, int days, int hours)
        {
            return basePrice * (days + (decimal)hours / 24);
        }
    }

}
