using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;
using MongoDB.Driver;

namespace WebAPI.Models
{

    public class RestaurantListings
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public address? address { get; set; }
        


        public string? borough { get; set; }
        public string? cuisine { get; set; }

        public List<grades>? grades { get; set; }

        public string? name { get; set; }

        public string? restaurant_id { get; set; }

    }
    
    public class address
    {
        public string? building { get; set; }
        /*public class coord
        {
            public double? Zero {get; set;}
            public double? One { get; set;} 
            }*/
        public double[]? coord { get; set; }
        public string? street { get; set; }

        public string? zipcode { get; set; }
    }

    
    public class grades
    {
        public DateTime? date { get; set; }

        public string? grade { get; set; }

        public int? score { get; set; }
    }
    
}
