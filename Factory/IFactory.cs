using MongoDbMigration.Interfaces;

namespace MongoDbMigration.Factory
{
    public interface IFactory
    {
        ICarInterface GetCarInstance();
        IPersonInterface GetPersonInstance();
    }
}