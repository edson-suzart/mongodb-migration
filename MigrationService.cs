using MongoDB.Driver;
using MongoDbMigration.Interfaces;
using MongoDbMigration.Migrations;

namespace MongoDbMigration
{
    public class MigrationService : IMigrationService
    {
        public async Task RunMigrations()
        {
            await ExecuteMigrations();
        }

        public async Task ExecuteMigrations()
        {
            await Task.Run(() =>
            {
                RunUps();
                RunDowns();
            }).ConfigureAwait(false);
        }

        private static void RunUps()
        {
            var db = GetMongoDb();
            new CarMigration().Up(db);
            new PersonMigration().Up(db);
        }

        private static void RunDowns()
        {
            var db = GetMongoDb();
            new CarMigration().Down(db);
            new PersonMigration().Down(db);
        }

        private static IMongoDatabase GetMongoDb()
        {
            var _mongoClient = new MongoClient("mongodb://localhost:27017");
            return _mongoClient.GetDatabase("registration");
        }
    }
}
