using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace booking_system.models
{
    [BsonIgnoreExtraElements]
    public class Services
	{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = string.Empty;

        [BsonElement("category")]
        public string Category { get; set; } = string.Empty;

        [BsonElement("price")]
        public string Price { get; set; } = string.Empty;

        public Services()
		{
		}
	}
}

