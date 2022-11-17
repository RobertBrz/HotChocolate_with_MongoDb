using HotChocolate_MongoDb.Models;
using HotChocolate_MongoDb.Models.Interfaces;
using HotChocolate_MongoDb.Services.Interfaces;

namespace HotChocolate_MongoDb.Services
{
    public class CarsService : ICarsService
    {
        public CarsService()
        {

        }

        List<ICar> ICarsService.GetAllCars()
        {
            return new List<ICar>() { new Car() { Model = "model1", Owner = new Owner() { Name = "name1 " }, Plate = "plate 1" } };
        }

        ICar ICarsService.GetCarByOwner(Owner owner)
        {
            return new Car() { Model = "2" };
        }
    }
}
