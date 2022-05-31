using MongoDB.Driver;
using MongoDB.Bson;
using dotenv.net.Utilities;
using dotenv.net;
using WebAPI.Models;
using Microsoft.Extensions.Options;

namespace WebAPI.Database
{
    public class DBServices
    {
        private IMongoCollection<RestaurantListings>? _restaurants;

        public DBServices(IOptions<MongoDBSettings> settings)
        {
            DotEnv.Load();
            settings.Value.ConnectionURI = EnvReader.GetStringValue("MONGO");
            
            MongoClient client = new MongoClient(settings.Value.ConnectionURI);

            IMongoDatabase database = client.GetDatabase(settings.Value.DatabaseName);

            _restaurants = database.GetCollection<RestaurantListings>(settings.Value.CollectionName);
        }
        public async Task<List<RestaurantListings>> GetAsync()
        {
            return await _restaurants.Find(new BsonDocument()).Limit(10).ToListAsync();
        }
    }

    
    
}
