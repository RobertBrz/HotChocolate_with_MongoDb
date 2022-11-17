using HotChocolate_MongoDb.Models.Interfaces;
using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.Serialization;

namespace HotChocolate_MongoDb.Models
{
    [DataContract]
    [BsonIgnoreExtraElements]
    public class Car :ICar
    {
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public string Plate { get; set; }
        [DataMember]
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
