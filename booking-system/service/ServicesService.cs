using System;
using booking_system.models;
using MongoDB.Driver;

namespace booking_system.service
{
	public class ServicesService:IServicesService
	{
        private readonly IMongoCollection<Services> _service;

        public ServicesService(IServicesDatabaseSettings settings, IMongoClient mongoClient)
		{
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _service = database.GetCollection<Services>(settings.ServicesCollectionName);
        }

        public Services create(Services service)
        {
            _service.InsertOne(service);
            return service;
        }

        public List<Services> Get()
        {
            return _service.Find(Services => true).ToList();
        }

        public Services get(string id)
        {
            return _service.Find(Services => Services.Id == id).FirstOrDefault();
        }

        public void remove(string id)
        {
            _service.DeleteOne(Services => Services.Id == id);
        }
    }
}

