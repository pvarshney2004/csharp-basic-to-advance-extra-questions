using System;
using System.Collections.Generic;
using System.Text;

namespace Eco_Ride
{
    public class EcoRideMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Eco-Ride Urban Mobility System");
            Console.WriteLine("-----------------------------------------");
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new ElectricCar(1, "EcoCar Model X", 85, 4, "Good"),
                new ElectricScooter(2, "EcoScooter Model S", 60, 25, "Needs Service")
            };
            double tripDistance = 10.0;
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Vehicle ID: {vehicle.VehicleId}, Model: {vehicle.Model}, Maintainance Status: {vehicle.MaintenanceStatus}, Distance covered: {tripDistance}km");
                vehicle.CalculateTripCost(tripDistance);
                Console.WriteLine("------------------------------");
            }
        }
    }
}
