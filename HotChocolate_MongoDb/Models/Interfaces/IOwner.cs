namespace HotChocolate_MongoDb.Models.Interfaces
{
    public interface IOwner
    {
        public string Name { get; set; }

        public List<Car> Cars { get; set; }
    }
}
