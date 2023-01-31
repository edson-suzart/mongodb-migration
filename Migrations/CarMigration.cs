using Mongo.Migration.Migrations.Database;
using MongoDB.Driver;
using MongoDbMigration.ModelsMigration;

namespace MongoDbMigration.Migrations
{
    public class CarMigration : DatabaseMigration
    {
        public CarMigration() : base("0.0.1")
        {
        }

        public override void Up(IMongoDatabase db)
        {
            var collection = db.GetCollection<Car>("Car"); 
            collection.InsertOne(new Car
            {
                Brand = "Fiat",
                Name = "Uno",
                Year = 2010,
                Type = Enums.TypesEnum.AddMigration
            });

            collection.Indexes.CreateOne(
                new CreateIndexModel<Car>(
                    keys: Builders<Car>.IndexKeys.Ascending("ExpiredAt"),
                    options: new CreateIndexOptions
                    {
                        ExpireAfter = TimeSpan.FromDays(90),
                        Name = "ExpireAtIndex"
                    }
                )
            );
        }

        public override void Down(IMongoDatabase db)
        {
            db.DropCollection("Car");
        }
    }
}
