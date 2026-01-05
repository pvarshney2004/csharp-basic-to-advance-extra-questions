using System;
using System.Collections.Generic;
using System.Text;

namespace Eco_Ride
{
    public class ElectricScooter : Vehicle
    {
        private int maxSpeed;
        public ElectricScooter(int vehicleId, string model, int batteryPercentage, int maxSpped, string maintainance)
            : base(vehicleId, model, batteryPercentage, maintainance)
        {
            this.maxSpeed = maxSpped;
        }
        public override void CalculateTripCost(double distance)
        {
            double baseFare = 1.00;
            double costPerKm = 0.15;
            double totalCost = baseFare + (distance * costPerKm);
            Console.WriteLine($"The total trip cost for the electric scooter is: ${totalCost}");
        }
    }
}
