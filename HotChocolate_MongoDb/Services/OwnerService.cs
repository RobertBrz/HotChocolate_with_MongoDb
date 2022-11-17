using HotChocolate_MongoDb.Models;
using HotChocolate_MongoDb.Models.Interfaces;
using HotChocolate_MongoDb.Services.Interfaces;

namespace HotChocolate_MongoDb.Services
{
    public class OwnerService : IOwnerService
    {
        public List<IOwner> GetAllOwners()
        {
            return new List<IOwner>() { new Owner() { Name = "testname" } };
        }
    }
}
