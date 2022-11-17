using HotChocolate_MongoDb.Models.Interfaces;

namespace HotChocolate_MongoDb.Models
{
    public class Owner : IOwner
    {
        public string Name { get; set; } =  string.Empty;
        public List<Car> Cars { get; set; }
    }
}