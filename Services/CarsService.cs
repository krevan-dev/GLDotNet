using GLDotNet.Database;
using GLDotNet.Models;

namespace GLDotNet.Services
{
  public class CarsService
  {
    internal List<Car> GetAll()
    {
      return FakeDb.Cars;
    }
    internal Car GetById(string? carId)
    {
      Car? foundCar = FakeDb.Cars.Find(c => c.Id == carId);
      if (foundCar == null)
      {
        throw new Exception("No car found with that Id");
      }
      return foundCar;
    }

    internal Car Create(Car newCar)
    {
      FakeDb.Cars.Add(newCar);
      return newCar;
    }

    internal Car Delete(string carId)
    {
      Car foundCar = GetById(carId);
      FakeDb.Cars.Remove(foundCar);
      return foundCar;
    }

    internal Car Edit(Car editedCar)
    {
      Car originalCar = GetById(editedCar.Id);
      originalCar.Make = editedCar.Make != null ? editedCar.Make : originalCar.Make;
      originalCar.Model = editedCar.Model != null ? editedCar.Model : originalCar.Model;
      originalCar.Year = editedCar.Year != 0 ? editedCar.Year : originalCar.Year;
      originalCar.Price = editedCar.Price != 0 ? editedCar.Price : originalCar.Price;
      originalCar.Color = editedCar.Color != null ? editedCar.Color : originalCar.Color;
      originalCar.Description = editedCar.Description != null ? editedCar.Description : originalCar.Description;
      return originalCar;
    }
  }
}