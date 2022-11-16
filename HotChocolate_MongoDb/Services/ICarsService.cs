using HotChocolate_MongoDb.Models;

namespace HotChocolate_MongoDb.Services
{
    public interface ICarsService
    {
        List<Car> GetAll();
        Car GetByOwner(Owner owner);
        List<ICar> GetByResolver();
    }
}
