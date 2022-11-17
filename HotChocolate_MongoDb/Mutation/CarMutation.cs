using HotChocolate_MongoDb.Models;
using HotChocolate_MongoDb.Services.Interfaces;

namespace HotChocolate_MongoDb.Mutation
{
    [ExtendObjectType(typeof(Mutation))]
    public class CarMutation
    {
        ICarsService _carsService;
        public CarMutation(ICarsService carsService)
        {
            _carsService = carsService;
        }

        public Car AddCar(Car car)
        {
            return _carsService.AddCar(car);
        }
    }
}
