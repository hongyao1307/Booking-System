using System;
using booking_system.models;

namespace booking_system.service
{
	public interface IAppointmentsService
	{
        List<Appointments> Get(DateTime booking_date);
        Appointments get(string id);
        Appointments create(Appointments appointment);
        List<Appointments> choose_existstaffs_id(DateTime booking_date, string booking_time);
        void update(string id, Appointments appointment);
        void remove(string id);
    }
}

