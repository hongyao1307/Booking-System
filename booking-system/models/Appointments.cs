using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace booking_system.models
{
	[BsonIgnoreExtraElements]
	public class Appointments
	{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("guest_name")]
        public string GuestName { get; set; } = string.Empty;

        [BsonElement("guest_id")]
        public string GuestId { get; set; } = string.Empty;

        [BsonElement("service_name")]
        public string ServiceName { get; set; } = string.Empty;

        [BsonElement("service_id")]
        public string ServiceId { get; set; } = string.Empty;

        [BsonElement("staffs_name")]
        public string StaffsName { get; set; } = string.Empty;

        [BsonElement("staffs_id")]
        public string StaffsId { get; set; } = string.Empty;

        [BsonElement("booking_date")]
        //[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local, DateOnly =true)]
        public DateTime BookingDate { get; set; }

        [BsonElement("booking_time")]
        public string BookingTime { get; set; } = string.Empty;

        public Appointments()
		{
		}
	}
}

