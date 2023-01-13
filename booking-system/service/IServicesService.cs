using System;
using booking_system.models;

namespace booking_system.service
{
	public interface IServicesService
	{
        List<Services> Get();
        Services get(string id);
        Services create(Services service);
        void remove(string id);
    }
}

