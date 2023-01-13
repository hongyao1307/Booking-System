using System;
using booking_system.models;

namespace booking_system.service
{
	public interface IGuestsService
	{
		List<Guests> Get();
		Guests get(string id);
		Guests create(Guests guests);
		void update(string id, Guests guests);
		void remove(string id);

	}
}

