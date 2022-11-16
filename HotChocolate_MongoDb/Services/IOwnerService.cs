using HotChocolate_MongoDb.Models;

namespace HotChocolate_MongoDb.Services
{
    public interface IOwnerService
    {
        public List<Owner> GetAllOwners();

    }
}
