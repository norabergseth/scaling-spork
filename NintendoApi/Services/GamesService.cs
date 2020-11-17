using MongoDB.Driver;
using NintendoApi.Models;
using System.Linq;
using System.Collections.Generic;

namespace NintendoApi.Services {

    public class GamesService {

        private readonly IMongoCollection<Game> _games;

        public GamesService(INintendoDatabaseSettings settings) {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _games = database.GetCollection<Game>(settings.GamesCollectionName);
        }

        public List<Game> Get() {
            return _games.Find(game => true).ToList();
        }

    }
}
// hello