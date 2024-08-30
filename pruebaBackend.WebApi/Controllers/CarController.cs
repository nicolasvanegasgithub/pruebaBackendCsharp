using Microsoft.AspNetCore.Mvc;
using pruebaBackend.Domain.Entities;
using pruebaBackend.WebApi.ApplicationService;
using pruebaBackend.WebApi.Command;

namespace pruebaBackend.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly CarService _carService;

        public CarController(CarService carService)
        {
            _carService = carService;
        }

        [HttpPost]
        public async Task AddCarAsync([FromBody] CreateCarCommand createCarCommand)
        {
            await _carService.CommandHandler(createCarCommand);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarsAsync(int id)
        {
            var car = await _carService.GetCarsAsync(id);
            return Ok(car);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCars()
        {
            var cars = await _carService.GetAllCarsAsync();
            return Ok(cars);
        }
    }
}
