using MongoDB.Driver;
using NintendoApi.Models;
using System.Linq;
using System.Collections.Generic;

namespace NintendoApi.Services {

    public class GamesService {

        private readonly IMongoCollection<Games> _games;

        public GamesService(INintendoDatabaseSettings settings) {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _games = database.GetCollection<Games>(settings.GamesCollectionName);
        }

        public List<Games> Get() {
            return _games.Find(game => true).ToList();
        }

    }
}
// hello