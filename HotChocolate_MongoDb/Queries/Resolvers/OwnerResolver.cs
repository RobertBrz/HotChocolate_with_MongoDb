using HotChocolate_MongoDb.Models;
using HotChocolate_MongoDb.Models.Interfaces;
using HotChocolate_MongoDb.Services.Interfaces;

namespace HotChocolate_MongoDb.Queries.Resolvers
{
    [ExtendObjectType(typeof(Query))]
    public class OwnerResolver
    {
        IOwnerService _ownersService;

        public OwnerResolver(IOwnerService ownersService)
        {
            _ownersService = ownersService;
        }

        public List<IOwner> GetAllOwners() => _ownersService.GetAllOwners();

    }
}
