namespace inheritance
{
  public class GasVehicle : Vehicle
  {

    public double BatteryKWh { get; private set; }


    public GasVehicle(double batteryKwh) {
      BatteryKWh = batteryKwh;
    }



    public void ChargeBattery()
    {
      System.Console.WriteLine("Charging Battery...");
    }


  }
}