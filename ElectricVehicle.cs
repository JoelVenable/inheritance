namespace inheritance
{
  class ElectricVehicle : Vehicle
  {
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
      System.Console.WriteLine("Battery Charging....");
    }
  }
}