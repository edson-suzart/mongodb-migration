using MongoDB.Driver;
using MongoDbMigration.Interfaces;

namespace MongoDbMigration.Factory
{
    public class PersonService : IPersonInterface
    {
        private readonly IMongoClient _mongoClient;

        public PersonService(IMongoClient mongoClient)
        {
            _mongoClient = mongoClient;
        }

        public IMongoDatabase GetMongoPersonDb()
        {
            return _mongoClient.GetDatabase("Registration");
        }
    }
}
