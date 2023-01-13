using System;
namespace booking_system.models
{
	public class StaffDatabaseSettings: IStaffDatabaseSettings
    {
        public string StaffCollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;

        public StaffDatabaseSettings()
		{
		}
	}
}

