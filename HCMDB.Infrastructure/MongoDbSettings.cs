namespace HCMDB.Infrastructure
{
    public class MongoDbSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public List<string> CollectionNames { get; set; } = null!;
    }
}