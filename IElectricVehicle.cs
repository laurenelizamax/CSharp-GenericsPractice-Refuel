namespace GenericPracticeRefuel
{
    public interface IElectricVehicle
    {
        int BatterykWh { get; set; }
        void ChargeBattery();
    }
}