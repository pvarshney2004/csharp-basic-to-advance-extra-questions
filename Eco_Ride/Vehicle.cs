using System;
using System.Collections.Generic;
using System.Text;

namespace Eco_Ride
{
    public class Vehicle
    {
        public int VehicleId;
        public string Model;
        private int _batteryPercentage;
        private string maintenanceStatus;
        public int BatteryPercentage
        {
            get { return _batteryPercentage; }
            set
            {
                if (value < 0)
                {
                    _batteryPercentage = 0;
                }
                else if (value > 100)
                {
                    _batteryPercentage = 100;
                }
                else
                {
                    _batteryPercentage = value;
                }

            }
        }
        public string MaintenanceStatus
        {
            get { return maintenanceStatus; }
            set
            {
                if (value == "Good" || value == "Needs Service" || value == "Out of Service")
                {
                    maintenanceStatus = value;
                }
                else
                {
                    throw new ArgumentException("Invalid maintenance status");
                }
            }
        }


        public Vehicle(int vehicleId, string model, int batteryPercentage, string maintainanceStatus)
        {
            VehicleId = vehicleId;
            Model = model;
            BatteryPercentage = batteryPercentage;
            MaintenanceStatus = maintainanceStatus;
        }
    }
}
