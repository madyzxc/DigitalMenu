using System.Collections.Generic;
using DigitalMenuApi.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace DigitalMenuApi.Services
{
    public class DishService : IDishService
    {
        private readonly IMongoCollection<Dish> _dishes;

        public DishService(IDigitalMenuDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _dishes = database.GetCollection<Dish>(settings.DishesCollectionName);
        }

        public ActionResult<IEnumerable<Dish>> Get() => _dishes.Find(dish => true).ToList();

        public Dish Get(string id) => _dishes.Find<Dish>(dish => dish.Id == id).FirstOrDefault();

        public Dish Create(Dish dish)
        {
            _dishes.InsertOne(dish);
            return dish;
        }

        public void Update(string id, Dish dishIn) => _dishes.ReplaceOne(dish => dish.Id == id, dishIn);

        public void Remove(Dish dishIn) => _dishes.DeleteOne(dish => dish.Id == dishIn.Id);

        public void Remove(string id) =>  _dishes.DeleteOne(dish => dish.Id == id);
    }
    
}
