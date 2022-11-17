using HotChocolate_MongoDb.Models;
using HotChocolate_MongoDb.Models.Interfaces;

namespace HotChocolate_MongoDb.Services.Interfaces
{
    public interface ICarsService
    {
        List<Car> GetAllCars();
        List<Car> GetCarByOwner(string ownerName);
        Car AddCar(Car car);
    }
}
