namespace HotChocolate_MongoDb.Models
{
    public class Owner
    {
        public string Name { get; set; }

        public List<Car> Cars { get; set; }
    }
}