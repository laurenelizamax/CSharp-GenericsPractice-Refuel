using System;
using System.Collections.Generic;

namespace GenericPracticeRefuel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IGasVehicle> gasVehicles = new List<IGasVehicle>();
            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>();


            // Instance of a tesla class, we treat it as an ielectricvehicle
            var myTesla = new Tesla();
            var myCessna = new Cessna();
            var myRam = new Ram();
            var myZero = new Zero();
            var myPrius = new Prius();

            gasVehicles.Add(myRam);
            gasVehicles.Add(myCessna);
            gasVehicles.Add(myPrius);

            electricVehicles.Add(myTesla);
            electricVehicles.Add(myZero);
            electricVehicles.Add(myPrius);

            GasStation gasStation = new GasStation();
            BatteryStation batteryStation = new BatteryStation();

            gasStation.Refuel(gasVehicles);
            batteryStation.Refuel(electricVehicles);

        }
    }
}
