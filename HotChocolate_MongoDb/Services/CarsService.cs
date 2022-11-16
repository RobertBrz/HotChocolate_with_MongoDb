using HotChocolate_MongoDb.Models;

namespace HotChocolate_MongoDb.Services
{
    public class CarsService : ICarsService
    {
        public CarsService()
        {

        }

        public List<Car> GetAll()
        {
            return new List<Car>() { new Car() { Model = "model1", Owner = new Owner() { Name = "name1 " }, Plate = "plate 1" } };
        }

        public Car GetByOwner(Owner owner)
        {
            return new Car() { Model = "2" };
        }

        public List<ICar> GetByResolver()
        {
            return new List<ICar>() { new Car() { Model = "resolver1", Owner = new Owner() { Name = "name1 " }, Plate = "plate res 1" } };

        }
    }
}
