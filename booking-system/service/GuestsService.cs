using System;
using booking_system.models;
using MongoDB.Driver;

namespace booking_system.service
{
	public class GuestsService : IGuestsService
    {
        private readonly IMongoCollection<Guests> _guests;

        public GuestsService(IGuestsDatabaseSettings settings, IMongoClient mongoClient)
		{
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _guests = database.GetCollection<Guests>(settings.GuestsCollectionName);
		}

        public Guests create(Guests guests)
        {
            _guests.InsertOne(guests);
            return guests;
        }

        public List<Guests> Get()
        {
            return _guests.Find(Guests => true).ToList();
        }

        public Guests get(string id)
        {
            return _guests.Find(Guests => Guests.Id == id).FirstOrDefault();
        }

        public void remove(string id)
        {
            _guests.DeleteOne(Guests => Guests.Id == id);
        }

        public void update(string id, Guests guests)
        {
            _guests.ReplaceOne(Guests => Guests.Id == id, guests);
        }
    }
}

