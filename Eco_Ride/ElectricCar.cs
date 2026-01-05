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
    }

}
