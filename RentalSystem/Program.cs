using System;
using System.Windows.Forms;
using RentalSystem.Model;
using RentalSystem.View;
using RentalSystem.Controller;
using RentalSystem.Model.DAO;
using RentalSystem.Model.PricingStrategies;
using RentalSystem.Model.Entities;

namespace RentalSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Create the mock DAO
            IRentalItemDAO rentalItemDAO = new MockRentalItemDAO();

            // Create the inventory with the mock DAO
            var inventory = new RentalInventory(rentalItemDAO);

            // Create the rental controller
            var rentalController = new RentalController(inventory);

            // Add some sample items
            var standardStrategy = new StandardPricingStrategy();
            inventory.AddItem(new Vehicle("V1", "Sedan", "Toyota Corolla", 50m, standardStrategy));
            inventory.AddItem(new Vehicle("V2", "SUV", "Honda CR-V", 75m, standardStrategy));
            inventory.AddItem(new Tool("T1", "Drill", "Power Tools", 20m, standardStrategy));
            inventory.AddItem(new Tool("T2", "Lawn Mower", "Garden Tools", 35m, standardStrategy));

            // Start the application with the graphical interface
            Application.Run(new MainForm(rentalController));
        }
    }
}
