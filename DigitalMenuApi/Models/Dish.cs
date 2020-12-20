using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DigitalMenuApi.Models
{
    public class Dish
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }
        
        [BsonElement("Description")]
        public string Description { get; set; }
        
        [BsonElement("Price")]
        public decimal Price { get; set; }
        
        [BsonElement("CurrentStatus")]
        public string CurrentStatus { get; set; }
        
        [BsonElement("MinutesToBeServed")]
        public int MinutesToBeServed { get; set; }
        
        [BsonElement("TotalCalories")]
        public int TotalCalories { get; set; }
        
        [BsonElement("Category")]
        public string Category { get; set; }
        
        [BsonElement("WhenItIsAvailable")]
        public List<string> WhenItIsAvailable { get; set; }
        
        [BsonElement("FriendlyForWhichDiets")]
        public List<string> FriendlyForWhichDiets { get; set; }
        
        [BsonElement("FriendlyToWhichReligions")]
        public List<string> FriendlyToWhichReligions { get; set; }
        
        [BsonElement("AllergicReactions")]
        public List<string> AllergicReactions { get; set; }
        
        [BsonElement("SideOptions")]
        public List<string> SideOptions { get; set; }
        
    }
}
