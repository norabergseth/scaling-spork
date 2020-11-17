using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NintendoApi.Models {

    public class Games {
        
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Title { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public string GameCharacter { get; set; }
        public string Image { get; set; }
    }
}