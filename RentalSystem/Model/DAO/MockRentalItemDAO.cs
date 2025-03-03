using RentalSystem.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RentalSystem.Model.DAO
{
    public class MockRentalItemDAO : IRentalItemDAO
    {
        private List<RentalItem> items = new();

        public void Add(RentalItem item)
        {
            items.Add(item);
        }

        public void Update(RentalItem item)
        {
            var existingItem = items.FirstOrDefault(i => i.Id == item.Id);
            if (existingItem != null)
            {
                items.Remove(existingItem);
                items.Add(item);
            }
        }

        public void Delete(string id)
        {
            items.RemoveAll(i => i.Id == id);
        }

        public RentalItem GetById(string id)
        {
            return items.FirstOrDefault(i => i.Id == id);
        }

        public List<RentalItem> GetAll()
        {
            return new List<RentalItem>(items);
        }

        public List<RentalItem> GetAvailable()
        {
            return items.Where(i => i.IsAvailable).ToList();
        }

        public List<RentalItem> GetRented()
        {
            return items.Where(i => !i.IsAvailable).ToList();
        }
    }
}

