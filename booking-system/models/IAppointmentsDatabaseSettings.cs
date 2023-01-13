using System;
namespace booking_system.models
{
	public interface IAppointmentsDatabaseSettings
	{
        string AppointmentsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}

