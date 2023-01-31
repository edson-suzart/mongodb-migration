using Mongo.Migration.Documents;
using Mongo.Migration.Documents.Attributes;
using MongoDB.Bson;
using MongoDbMigration.Enums;

namespace MongoDbMigration.ModelsMigration
{
    [RuntimeVersion("0.0.2")]
    public class Person : IDocument
    {
        public ObjectId Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public TypesEnum Type { get; set; }
        public DocumentVersion Version { get; set; }
    }
}
