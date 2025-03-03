using System;
using System.Collections.Generic;
using RentalSystem.Model;
using RentalSystem.Model.Entities;
using RentalSystem.Model.PricingStrategies;

namespace RentalSystem.Controller
{
    public class RentalController
    {
        private readonly RentalInventory inventory;

        public RentalController(RentalInventory inventory)
        {
            this.inventory = inventory;
        }

        public void RentItem(string itemId, int days, int hours)
        {
            var item = inventory.GetItem(itemId);
            if (item == null)
                throw new ArgumentException("Item not found.");

            if (!item.IsAvailable)
                throw new InvalidOperationException("Item is not available for rent.");

            item.Rent();
            inventory.UpdateItem(item);
            decimal cost = item.CalculateRentalCost(days, hours);
            Console.WriteLine($"Item {item.Name} rented for {days} days and {hours} hours. Total cost: ${cost}");
        }

        public void ReturnItem(string itemId)
        {
            var item = inventory.GetItem(itemId);
            if (item == null)
                throw new ArgumentException("Item not found.");

            if (item.IsAvailable)
                throw new InvalidOperationException("Item is not currently rented.");

            item.Return();
            inventory.UpdateItem(item);
            Console.WriteLine($"Item {item.Name} returned successfully.");
        }

        public List<RentalItem> GetAllItems()
        {
            return inventory.GetAllItems();
        }

        public List<RentalItem> GetAvailableItems()
        {
            return inventory.GetAvailableItems();
        }

        public List<RentalItem> GetRentedItems()
        {
            return inventory.GetRentedItems();
        }

        public decimal CalculateRentalPrice(string itemId, int days, int hours, List<string> pricingStrategies)
        {
            var item = inventory.GetItem(itemId);
            if (item == null)
                throw new ArgumentException("Item not found.");

            IPriceCalculator strategy = new StandardPricingStrategy();

            foreach (var strategyName in pricingStrategies)
            {
                strategy = strategyName.ToLower() switch
                {
                    "standard" => new StandardPricingStrategy(),
                    "discount" => new DiscountPricingStrategy(strategy, 0.1m), // 10% discount
                    "weekly" => new WeeklyDiscountStrategy(strategy, 7, 0.15m), // 15% discount for each full week
                    _ => throw new ArgumentException($"Invalid pricing strategy: {strategyName}")
                };
            }

            item.SetPricingStrategy(strategy);
            return item.CalculateRentalCost(days, hours);
        }

        public RentalItem GetItem(string itemId)
        {
            return inventory.GetItem(itemId);
        }
    }
}