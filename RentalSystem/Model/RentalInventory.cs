using RentalSystem.Model.DAO;
using RentalSystem.Model.Entities;
using System.Collections.Generic;

namespace RentalSystem.Model
{
    public class RentalInventory
    {
        private readonly IRentalItemDAO rentalItemDAO;

        public RentalInventory(IRentalItemDAO rentalItemDAO)
        {
            this.rentalItemDAO = rentalItemDAO;
        }

        public void AddItem(RentalItem item)
        {
            rentalItemDAO.Add(item);
        }

        public RentalItem GetItem(string id)
        {
            return rentalItemDAO.GetById(id);
        }

        public List<RentalItem> GetAllItems()
        {
            return rentalItemDAO.GetAll();
        }

        public List<RentalItem> GetAvailableItems()
        {
            return rentalItemDAO.GetAvailable();
        }

        public List<RentalItem> GetRentedItems()
        {
            return rentalItemDAO.GetRented();
        }

        public void UpdateItem(RentalItem item)
        {
            rentalItemDAO.Update(item);
        }
    }
}

