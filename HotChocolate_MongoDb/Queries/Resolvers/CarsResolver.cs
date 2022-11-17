using HotChocolate_MongoDb.Models.Interfaces;
using HotChocolate_MongoDb.Services.Interfaces;

namespace HotChocolate_MongoDb.Queries.Resolvers
{
    [ExtendObjectType(typeof(Query))]
    public class CarsResolver
    {
        ICarsService _carsService;
        public CarsResolver(ICarsService carsService)
        {
            _carsService = carsService;
        }

        public List<ICar> GetAllCars()
        {
            return _carsService.GetAllCars();
        }
    }
}
