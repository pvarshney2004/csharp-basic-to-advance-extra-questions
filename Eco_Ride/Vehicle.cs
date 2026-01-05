using System;
using System.Collections.Generic;
using System.Text;

namespace Eco_Ride
{
    public class Vehicle
    {
        public int VehicleId;
        public string Model;
        public int BatteryPercentage;

        public Vehicle(int vehicleId, string model, int batteryPercentage)
        {
            VehicleId = vehicleId;
            Model = model;
            BatteryPercentage = batteryPercentage;
        }
    }
}
