namespace DigitalMenuApi.Models
{
    public class DigitalMenuDatabaseSettings : IDigitalMenuDatabaseSettings
    {
        public string DishesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
