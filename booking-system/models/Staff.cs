using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace booking_system.models
{
    [BsonIgnoreExtraElements]
    public class Staff
	{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("first_name")]
        public string FirstName { get; set; } = string.Empty;

        [BsonElement("last_name")]
        public string LastName { get; set; } = string.Empty;

        [BsonElement("job_title")]
        public string JobTitle { get; set; }

        public Staff()
		{
		}
	}
}

