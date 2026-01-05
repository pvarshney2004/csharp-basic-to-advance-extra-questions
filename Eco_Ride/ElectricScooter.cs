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
    }
}
