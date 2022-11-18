using HotChocolate_MongoDb.Models.Interfaces;
using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.Serialization;

namespace HotChocolate_MongoDb.Models
{
    [DataContract]
    [BsonIgnoreExtraElements]
    public class Car : ICar
    {
        [BsonId]
        [DataMember]
        public int  ID{ get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public string Plate { get; set; }
        [DataMember]
        public virtual Owner Owner { get; set; }
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
