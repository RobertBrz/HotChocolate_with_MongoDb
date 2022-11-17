using HCMDB.Infrastructure;
using HotChocolate_MongoDb.Models;
using HotChocolate_MongoDb.Models.Interfaces;
using HotChocolate_MongoDb.Services.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Reflection.Metadata.Ecma335;

namespace HotChocolate_MongoDb.Services
{
    public class CarsService : ICarsService
    {
        IMongoCollection<Car> _carsCollection;
        public CarsService(IOptions<MongoDbSettings> _bookStoreDatabaseSettings)
        {
            var mongoClient = new MongoClient(
            _bookStoreDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                _bookStoreDatabaseSettings.Value.DatabaseName);

            _carsCollection = mongoDatabase.GetCollection<Car>(
                _bookStoreDatabaseSettings.Value.CollectionNames.Where(x => x == "CarsCollection").Single());
        }

        public Car AddCar(Car car)
        {
            _carsCollection.InsertOne(car);
            return car;
        }

        List<Car> ICarsService.GetAllCars()
        {
            return  _carsCollection.Find(f => true).ToList();
        }

        List<Car> ICarsService.GetCarByOwner(string  ownerName)
        {
            return _carsCollection.Find(c => c.Owner.Name == ownerName).ToList();
        }
    }
}
