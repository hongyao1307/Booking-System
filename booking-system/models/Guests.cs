using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace booking_system.models
{
	[BsonIgnoreExtraElements]
	public class Guests
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; } = string.Empty;

		[BsonElement("first_name")]
		public string FirstName { get; set; } = string.Empty;

        [BsonElement("last_name")]
        public string LastName { get; set; } = string.Empty;

		[BsonElement("phone_number")]
		public string PhoneNumber { get; set; }

		[BsonElement("email")]
		public string Email { get; set; } = string.Empty;

        public Guests()
		{
		}
	}
}

