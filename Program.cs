using Microsoft.Extensions.DependencyInjection;
using Mongo.Migration.Startup;
using Mongo.Migration.Startup.DotNetCore;
using MongoDB.Driver;
using MongoDbMigration;
using MongoDbMigration.Factory;
using MongoDbMigration.Interfaces;

namespace ProgramNamespace
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var migration = new MigrationService();
            await migration.RunMigrations();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            var client = new MongoClient();
            services.AddSingleton<IMongoClient>(client);
            services.AddSingleton<IFactory, Factory>();
            services.AddScoped<ICarInterface, CarService>();
            services.AddScoped<IPersonInterface, PersonService>();
            services.AddSingleton<IMigrationService, MigrationService>();

            services.AddMigration(new MongoMigrationSettings
            {
                ConnectionString = "mongodb://localhost:27017",
                Database = "Registration"
            });
        }
    }
}

