using System;
using booking_system.models;
using MongoDB.Driver;

namespace booking_system.service
{
	public class AppointmentsService:IAppointmentsService
	{
        private readonly IMongoCollection<Staff> _staffs;
        private readonly IMongoCollection<Appointments> _appointment;

        public AppointmentsService(IStaffDatabaseSettings staff_settings, IAppointmentsDatabaseSettings appointments_settings, IMongoClient mongoClient)
		{
            var staff_database = mongoClient.GetDatabase(staff_settings.DatabaseName);
            _staffs = staff_database.GetCollection<Staff>(staff_settings.StaffCollectionName);

            var appointments_database = mongoClient.GetDatabase(appointments_settings.DatabaseName);
            _appointment = appointments_database.GetCollection<Appointments>(appointments_settings.AppointmentsCollectionName);
        }

        public List<Appointments> choose_existstaffs_id(DateTime booking_date, string booking_time)
        {
            return _appointment.Find(Appointments => Appointments.BookingDate == booking_date && Appointments.BookingTime == booking_time).ToList();
        }

        public Appointments create(Appointments appointment)
        {
            _appointment.InsertOne(appointment);
            return appointment;
        }

        public List<Appointments> Get(DateTime booking_date)
        {
            return _appointment.Find(Appointments => Appointments.BookingDate == booking_date).ToList();
        }

        public Appointments get(string id)
        {
            return _appointment.Find(Appointments => Appointments.Id == id).FirstOrDefault();
        }

        public void remove(string id)
        {
            _appointment.DeleteOne(Appointments => Appointments.Id == id);
        }

        public void update(string id, Appointments appointment)
        {
            _appointment.ReplaceOne(Appointments => Appointments.Id == id, appointment);
        }
    }
}

