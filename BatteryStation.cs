using System;
using System.Collections.Generic;

namespace GenericPracticeRefuel
{
    public class BatteryStation : IRefuelStation<IElectricVehicle>
    {
        public int BatterykWh { get; set; }
        public int Capacity { get; set; }

        public void ChargeBattery()
        {
            throw new NotImplementedException();
        }

        public void Refuel(List<IElectricVehicle> vehicles)
        {
            vehicles.ForEach(vehicle => vehicle.ChargeBattery());
        }
    }
}