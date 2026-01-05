using System;
using System.Collections.Generic;
using System.Text;

namespace Eco_Ride
{
    public class ElectricCar : Vehicle
    {
        private int seatingCapacity;
        public ElectricCar(int vehicleId, string model, int batteryPercentage, int seatingCapacity, string maintainance)
            : base(vehicleId, model, batteryPercentage, maintainance)
        {
            this.seatingCapacity = seatingCapacity;
        }
        public override void CalculateTripCost(double distance)
        {
            double baseFare = 5.00;
            double costPerKm = 0.50;
            double totalCost = baseFare + (distance * costPerKm);
            Console.WriteLine($"The total trip cost for the electric car is: ${totalCost}");
        }
    }

}
