using RentalSystem.Model.Entities;
using System.Collections.Generic;

namespace RentalSystem.Model.DAO
{
    public interface IRentalItemDAO
    {
        void Add(RentalItem item);
        void Update(RentalItem item);
        void Delete(string id);
        RentalItem GetById(string id);
        List<RentalItem> GetAll();
        List<RentalItem> GetAvailable();
        List<RentalItem> GetRented();
    }
}

