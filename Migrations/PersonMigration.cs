using Mongo.Migration.Migrations.Database;
using MongoDB.Driver;
using MongoDbMigration.ModelsMigration;

namespace MongoDbMigration.Migrations
{
    public class PersonMigration : DatabaseMigration
    {
        public PersonMigration() : base("0.0.1")
        {
        }

        public override void Up(IMongoDatabase db)
        {
            var collection = db.GetCollection<Person>("Person");
            collection.InsertOne(new Person
            {
                Age = 38,
                Name = "Geraldo",
                Id = new MongoDB.Bson.ObjectId(),
                Type = Enums.TypesEnum.AddMigration
            });
        }

        public override void Down(IMongoDatabase db)
        {
            db.DropCollection("Person");
        }
    }
}
