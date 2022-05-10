using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoCatalog.WebApi.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
