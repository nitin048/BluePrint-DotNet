using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BluePrintApi.Model
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("firstname")]
        public string FirstName { get; set; } = null!;

        [BsonElement("lastname")]
        public string LastName { get; set; } = null!;

        [BsonElement("email")]
        public string Email { get; set; } = null!;


        [BsonElement("mobile")]
        public long Mobile { get; set; }

        [BsonElement("password")]
        public string Password { get; set; } = null!;

        [BsonElement("role")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Role { get; set; } = null!;
    }
}
