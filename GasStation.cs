using System;
using System.Collections.Generic;

namespace GenericPracticeRefuel
{
    public class GasStation : IRefuelStation<IGasVehicle>
    {
        public int FuelCapacity { get; set; }
        public int FuelLevel { get; set; }
        public int Capacity { get; set; }

        public void RefuelTank()
        {
            throw new NotImplementedException();
        }

        public void Refuel(List<IGasVehicle> vehicles)
        {
            vehicles.ForEach(vehicle => vehicle.RefuelTank());
        }
    }
}