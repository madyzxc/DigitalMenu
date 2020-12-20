using System;
using System.Collections.Generic;
using DigitalMenuApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigitalMenuApi.Services
{
    public class MockDishService : IDishService
    {
        public ActionResult<IEnumerable<Dish>> Get()
        {
            return new List<Dish>
            {
                new Dish
                {
                    Id="00000",
                    Name = "Sauerbraten",
                    Description = "Roast Beef Stew",
                    Price = 11.93M,
                    CurrentStatus = "Available",
                    MinutesToBeServed = 20,
                    TotalCalories = 199,
                    Category = "main course",
                    WhenItIsAvailable = new List<string> {"dinner", "weekdays", "weekends"},
                    FriendlyForWhichDiets = new List<string> {"Carnivore", "Keto"},
                    FriendlyToWhichReligions = new List<string> {"Kosher", "Halal"},
                    AllergicReactions = new List<string> {"meat", "soy"},
                    SideOptions = new List<string>
                    {
                        "potato dumplings", "Spätzle", "potato pancakes", "boiled potatoes"
                    }
                }
            };

        }

        public Dish Get(string id)
        {
            return new Dish
            {
                Id="00000",
                Name = "Sauerbraten",
                Description = "Roast Beef Stew",
                Price = 11.93M,
                CurrentStatus = "Available",
                MinutesToBeServed = 20,
                TotalCalories = 199,
                Category = "main course",
                WhenItIsAvailable = new List<string> {"dinner", "weekdays", "weekends"},
                FriendlyForWhichDiets = new List<string> {"Carnivore", "Keto"},
                FriendlyToWhichReligions = new List<string> {"Kosher", "Halal"},
                AllergicReactions = new List<string> {"meat", "soy"},
                SideOptions = new List<string>
                {
                    "potato dumplings", "Spätzle", "potato pancakes", "boiled potatoes"
                }
            };
        }

        public Dish Create(Dish dish)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, Dish dishIn)
        {
            throw new NotImplementedException();
        }

        public void Remove(Dish dishIn)
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }
    }
}
