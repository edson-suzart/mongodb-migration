using Mongo.Migration.Documents;
using Mongo.Migration.Documents.Attributes;
using MongoDB.Bson;
using MongoDbMigration.Enums;

namespace MongoDbMigration.ModelsMigration
{
    [RuntimeVersion("0.0.1")]
    public class Car : IDocument
    {
        public ObjectId Id { get; set; }
        public string? Brand { get; set; }
        public string? Name { get; set; }
        public int Year { get; set; }
        public TypesEnum Type { get; set; }
        public DateTime ExpiredAt { get; set; }
        public DocumentVersion Version { get; set; }
    }
}
