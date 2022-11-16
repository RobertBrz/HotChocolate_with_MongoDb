using HotChocolate_MongoDb.Models;
using HotChocolate_MongoDb.Services;

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

        public List<ICar> GrtCarsByResolver()
        {
            return _carsService.GetByResolver();
        }
    }
}
