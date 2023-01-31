namespace MongoDbMigration.Interfaces
{
    public interface IMigrationService
    {
        Task RunMigrations();
        Task ExecuteMigrations();
    }
}