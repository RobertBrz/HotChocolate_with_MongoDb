using HotChocolate_MongoDb.Models;
using HotChocolate_MongoDb.Services;
using System.Reflection.Metadata.Ecma335;

namespace HotChocolate_MongoDb.Queries
{
    public class Query
    {
        ICarsService _carsService;
        IOwnerService _ownerService;
        public Query(
            ICarsService carsService,
            IOwnerService ownerService)
        {
            _carsService = carsService;
            _ownerService = ownerService;
        }


        public List<Owner> GetAlOwners()
        {
            return _ownerService.GetAllOwners();
        }

        public List<Car> GetAllCars()
        {
            return _carsService.GetAll();
        }
    }
}
