namespace DigitalMenuApi.Models
{
    public interface IDigitalMenuDatabaseSettings
    {
        string DishesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}