namespace NintendoApi.Models {

    public interface INintendoDatabaseSettings {

        string GamesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }

    public class NintendoDatabaseSettings : INintendoDatabaseSettings {
        public string GamesCollectionName  { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

}