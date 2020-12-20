using System.Collections.Generic;
using DigitalMenuApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigitalMenuApi.Services
{
    public interface IDishService
    {
        ActionResult<IEnumerable<Dish>> Get();
        Dish Get(string id);
        Dish Create(Dish dish);
        void Update(string id, Dish dishIn);
        void Remove(Dish dishIn);
        void Remove(string id);
    }
} 