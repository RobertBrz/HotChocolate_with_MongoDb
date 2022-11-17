using HotChocolate_MongoDb.Models.Interfaces;

namespace HotChocolate_MongoDb.Models
{
    public class Car :ICar
    {
        public string Model { get; set; }
        public string Plate { get; set; }

        public Owner Owner { get; set; }
    }

    [ExtendObjectType(typeof(Car))]
    public class CarExtension
    {
        public IEnumerable<string> GetModels([Parent] ICar car)
        {
            return new List<string>() { "models test" };
        }
    }
}
