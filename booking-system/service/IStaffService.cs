using System;
using booking_system.models;

namespace booking_system.service
{
	public interface IStaffService
	{
        List<Staff> Get();
        Staff get(string id);
        Staff create(Staff staffs);
        void remove(string id);
    }
}

