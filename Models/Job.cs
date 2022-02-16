namespace GLDotNet.Models
{
  public class Job
  {
    public Job(string jobTitle, int pay, string empType)
    {
      Id = Guid.NewGuid().ToString();
      JobTitle = jobTitle;
      Pay = pay;
      EmpType = empType;
    }
    public string? Id { get; set; }
    public string? JobTitle { get; set; }
    public int? Pay { get; set; }
    public string? EmpType { get; set; }
  }
}