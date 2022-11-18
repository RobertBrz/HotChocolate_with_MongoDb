using HCMDB.Infrastructure;
using HotChocolate_MongoDb.Models;
using HotChocolate_MongoDb.Models.Interfaces;
using HotChocolate_MongoDb.Services.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace HotChocolate_MongoDb.Services
{
    public class OwnerService : IOwnerService
    {
        IMongoCollection<Owner> _ownersCollection;
        public OwnerService(IOptions<MongoDbSettings> _bookStoreDatabaseSettings)
        {
            var mongoClient = new MongoClient(
          _bookStoreDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                _bookStoreDatabaseSettings.Value.DatabaseName);

            _ownersCollection = mongoDatabase.GetCollection<Owner>(
                _bookStoreDatabaseSettings.Value.CollectionNames.Where(x => x == "OwnerCollection").Single());
        }

        public Owner AddOwner(Owner owner)
        {
            _ownersCollection.InsertOne(owner);
            return owner;
        }

        public List<Owner> GetAllOwners()
        {
            return _ownersCollection.Find(f => true).ToList();
        }
    }
}
