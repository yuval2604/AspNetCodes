using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AspNetToDoList.Entities
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        public string Major { get; set; }
    }
}
