using System;
namespace booking_system.models
{
	public class ServicesDatabaseSettings: IServicesDatabaseSettings
	{
        public string ServicesCollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;

        public ServicesDatabaseSettings()
		{
		}
    }
}

