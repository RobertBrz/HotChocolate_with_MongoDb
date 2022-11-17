namespace HotChocolate_MongoDb.Models.Interfaces
{
    public interface ICar
    {
        public string Model { get; set; }
        public string Plate { get; set; }
        public Owner Owner { get; set; }
    }
}
