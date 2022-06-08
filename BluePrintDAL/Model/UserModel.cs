using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePrintDAL.Model
{
	    
    public class UserModel
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
