namespace inheritance
{
  public class Vehicle
  {
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public virtual void Drive()
    {
      System.Console.WriteLine("Vroom!");
    }
  }
}