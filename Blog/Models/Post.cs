using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Blog.Models
{
    [BsonIgnoreExtraElements]
    public class Post
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        public string Title { get; set; }
        
        public string Author { get; set; }
        
        public string Body { get; set; }
    }
}