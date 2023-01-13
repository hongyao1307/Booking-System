using System;
namespace booking_system.models
{
	public class GuestsDatabaseSettings : IGuestsDatabaseSettings
	{
		public string GuestsCollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;


        public GuestsDatabaseSettings()
		{
		}
	}
}

