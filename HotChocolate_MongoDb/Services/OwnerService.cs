using HotChocolate_MongoDb.Models;

namespace HotChocolate_MongoDb.Services
{
    public class OwnerService : IOwnerService
    {
        public List<Owner> GetAllOwners()
        {
            return new List<Owner>() { new Owner() { Name = "testname" } };
        }
    }
}
