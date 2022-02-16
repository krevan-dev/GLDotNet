namespace GLDotNet.Models
{
  public class Car
  {
    public Car(int year, string make, string model, int price, string color, string description)
    {
      Id = Guid.NewGuid().ToString();
      Year = year;
      Make = make;
      Model = model;
      Price = price;
      Color = color;
      Description = description;
    }
    public string? Id { get; set; }
    public int? Year { get; set; }
    public string? Make { get; set; }
    public string? Model { get; set; }
    public int? Price { get; set; }
    public string? Color { get; set; }
    public string? Description { get; set; }
  }
}