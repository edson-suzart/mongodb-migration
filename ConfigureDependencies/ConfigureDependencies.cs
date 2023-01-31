using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mongo.Migration.Startup;
using Mongo.Migration.Startup.DotNetCore;
using MongoDB.Driver;
using MongoDbMigration.Factory;
using MongoDbMigration.Interfaces;

namespace MongoDbMigration.ConfigureDependencies
{
    public class ConfigureDependencies
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            var client = new MongoClient();
            services.AddSingleton<IMongoClient>(client);
            services.AddSingleton<IFactory, Factory.Factory>();
            services.AddScoped<ICarInterface, CarService>();
            services.AddScoped<IPersonInterface, PersonService>();

            services.AddMigration(new MongoMigrationSettings
            {
                ConnectionString = configuration.GetSection("mongodb://localhost:27017").Value,
                Database = configuration.GetSection("MongoDb:Database").Value
            });
        }
    }
}
