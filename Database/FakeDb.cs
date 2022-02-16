using GLDotNet.Models;

namespace GLDotNet.Database
{
  public class FakeDb
  {
    public static List<Car> Cars { get; set; } = new List<Car>()
    {
      new Car(2007, "Nissan", "Titan", 14000, "Black", "New tires, semi new brakes"),
      new Car(2003, "Nissan", "Xterra", 7000, "Orange", "Small dents, missing fender"),
      new Car(2017, "Honda", "Civic", 14000, "Red", "Collision Magnet")
    };
    public static List<House> Houses { get; set; } = new List<House>()
    {
      new House(1985, "Apartment", 2, 1, 900, "Boise"),
      new House(2015, "Cottage", 3, 2, 1400, "Meridian"),
      new House(2004, "Colonial", 5, 3, 2500, "Eagle")
    };
    public static List<Job> Jobs { get; set; } = new List<Job>()
    {
      new Job("Software Developer", 60000, "Full-Time"),
      new Job("Mover", 20000, "Part-Time"),
      new Job("Correctional Officer", 35000, "Full-Time")
    };
  }
}