using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DigitalMenuApi.Models;
using DigitalMenuApi.Services;

namespace DigitalMenuApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishesController : ControllerBase
    {
        private readonly IDishService _dishService;

        public DishesController(IDishService dishService)
        {
            _dishService = dishService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Dish>> Get() =>_dishService.Get();

        [HttpGet("{id:length(24)}", Name = "GetDish")]
        public ActionResult<Dish> Get(string id)
        {
            var dish = _dishService.Get(id);

            if (dish == null)
            {
                return NotFound();
            }

            return Ok(dish);
        }

        [HttpPost]
        public ActionResult<Dish> Create(Dish dish)
        {
            _dishService.Create(dish);

            return CreatedAtRoute("GetDish", new { id = dish.Id.ToString() }, dish);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Dish dishIn)
        {
            var dish = _dishService.Get(id);

            if (dish == null)
            {
                return NotFound();
            }

            _dishService.Update(id, dishIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var dish = _dishService.Get(id);

            if (dish == null)
            {
                return NotFound();
            }

            _dishService.Remove(dish.Id);

            return NoContent();
        }
    }
}
