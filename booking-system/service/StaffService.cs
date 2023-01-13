using System;
using booking_system.models;
using MongoDB.Driver;

namespace booking_system.service
{
	public class StaffService:IStaffService
	{
        private readonly IMongoCollection<Staff> _staffs;
        public StaffService(IStaffDatabaseSettings settings, IMongoClient mongoClient)
		{
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _staffs = database.GetCollection<Staff>(settings.StaffCollectionName);
        }

        public Staff create(Staff staffs)
        {
            _staffs.InsertOne(staffs);
            return staffs;
        }

        public List<Staff> Get()
        {
            return _staffs.Find(Staff => true).ToList();
        }

        public Staff get(string id)
        {
            return _staffs.Find(Staff => Staff.Id == id).FirstOrDefault();
        }

        public void remove(string id)
        {
            _staffs.DeleteOne(Staff => Staff.Id == id);
        }
    }
}

