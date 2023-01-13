using System;
namespace booking_system.models
{
	public class AppointmentsDatabaseSettings:IAppointmentsDatabaseSettings
	{
		public AppointmentsDatabaseSettings()
		{
		}

        public string AppointmentsCollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;
    }
}

