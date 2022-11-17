using HotChocolate_MongoDb.Models;
using HotChocolate_MongoDb.Models.Interfaces;

namespace HotChocolate_MongoDb.Services.Interfaces
{
    public interface ICarsService
    {
        List<ICar> GetAllCars();
        ICar GetCarByOwner(Owner owner);

    }
}
