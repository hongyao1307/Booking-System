using System;
namespace booking_system.models
{
	public interface IStaffDatabaseSettings
	{
        string StaffCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}

