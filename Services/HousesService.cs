using GLDotNet.Database;
using GLDotNet.Models;

namespace GLDotNet.Services
{
  public class HousesService
  {
    internal List<House> GetAll()
    {
      return FakeDb.Houses;
    }
  }
}