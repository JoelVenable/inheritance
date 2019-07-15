namespace inheritance
{
  public class Cessna
  {
    public double FuelCapacity { get; set; }
    public string MainColor { get; set; }
    public int MaximumOccupancy { get; set; }

    public void RefuelTank()
    {
      System.Console.WriteLine("Refueling gasoline...");
    }
  }
}