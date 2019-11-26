using System;

namespace GenericPracticeRefuel
{
    public class Cessna : IVehicle, IGasVehicle
    {
        public int FuelCapacity { get; set; }
        public int FuelLevel { get; set; }

        public void Drive()
        {
            Console.WriteLine("Zoooomm!");
        }

        public void RefuelTank()
        {
            FuelLevel = FuelCapacity;
        }
    }
}