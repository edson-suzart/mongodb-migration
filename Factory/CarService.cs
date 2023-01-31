using MongoDB.Driver;
using MongoDbMigration.Interfaces;

namespace MongoDbMigration.Factory
{
    public class CarService : ICarInterface
    {
        private readonly IMongoClient _mongoClient;

        public CarService(IMongoClient mongoClient)
        {
            _mongoClient = mongoClient;
        }

        public IMongoDatabase GetMongoCarDb()
        {
            return _mongoClient.GetDatabase("Registration");
        }
    }
}
