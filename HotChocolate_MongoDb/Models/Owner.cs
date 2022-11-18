using HotChocolate_MongoDb.Models.Interfaces;
using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.Serialization;

namespace HotChocolate_MongoDb.Models
{
    [DataContract]
    [BsonIgnoreExtraElements]
    public class Owner : IOwner
    {
        [DataMember]
        public string Name { get; set; } = string.Empty;
        [DataMember]
        public virtual List<Car> Cars { get; set; } = new();
    }
}