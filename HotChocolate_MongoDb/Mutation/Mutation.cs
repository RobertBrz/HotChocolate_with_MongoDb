using HotChocolate_MongoDb.Models;
using HotChocolate_MongoDb.Services.Interfaces;

namespace HotChocolate_MongoDb.Mutation
{
    public class Mutation
    {
        ICarsService _carsService;
        public Mutation(ICarsService carsService)
        {
            _carsService = carsService; 
        }


        public string getstring(string a)
        {
            return a;
        }
    }
}

