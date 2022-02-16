namespace GLDotNet.Models
{
  public class House
  {
    public House(int year, string type, int bed, int bath, int sqft, string location)
    {
      Id = Guid.NewGuid().ToString();
      Year = year;
      Type = type;
      Bed = bed;
      Bath = bath;
      Sqft = sqft;
      Location = location;
    }
    public string? Id { get; set; }
    public int? Year { get; set; }
    public string? Type { get; set; }
    public int? Bed { get; set; }
    public int? Bath { get; set; }
    public int? Sqft { get; set; }
    public string? Location { get; set; }
  }
}