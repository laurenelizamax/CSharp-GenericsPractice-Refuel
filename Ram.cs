using System;

namespace GenericPracticeRefuel
{
    public class Ram : IVehicle, IGasVehicle
    {
        public int FuelCapacity { get; set; }
        public int FuelLevel { get; set; }

        public void Drive()
        {
            Console.WriteLine("Rooooaar!");
        }

        public void RefuelTank()
        {
            FuelLevel = FuelCapacity;
        }
    }
}