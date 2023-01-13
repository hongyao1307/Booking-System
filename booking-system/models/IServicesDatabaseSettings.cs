using System;
namespace booking_system.models
{
	public interface IServicesDatabaseSettings
	{
        string ServicesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}

