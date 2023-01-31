using MongoDB.Driver;

namespace MongoDbMigration.Interfaces
{
    public interface IPersonInterface
    {
        IMongoDatabase GetMongoPersonDb();
    }
}
