using AutomobileRentals.Contracts;
using AutomobileRentals.EntityFramework.Models;
using AutomobileRentals.Models;
using AutomobileRentals.Models.CarTypeModels;
using AutomobileRentals.Parameters;
using Microsoft.AspNetCore.Mvc;

namespace AutomobileRentals.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarTypeController : ControllerBase
    {
        private readonly ICarTypeService _carTypeService;

        public CarTypeController(ICarTypeService carType)
        {
            _carTypeService = carType;
        }

        // GET: api/Vehicles
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<CarType>>> GetVehicle()
        {
            var result = await _carTypeService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<PagedResult<CarTypeDTO>>> GetCarTypes([FromQuery] QueryParameters queryParameters)
        {
            var result = await _carTypeService.GetCarTypes(queryParameters);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CarType>> GetVehicle(int id)
        {
            var carType = await _carTypeService.GetCarType(id);

            if (carType == null)
            {
                return NotFound();
            }

            return carType;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarType(int id, CarType carType)
        {
            var result = await _carTypeService.PutCarType(id, carType);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Vehicle>> PostCarType(CarType carType)
        {
            var result = await _carTypeService.PostCarType(carType);
            return Ok(result);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarType(int id)
        {
            var result = await _carTypeService.DeleteCarType(id);
            return Ok(result);
        }

        [HttpGet, Route("/car-type-exists")]
        public async Task<bool> VehicleExists(int id)
        {
            var result = await _carTypeService.CarTypeExists(id);
            return result;
        }
    }
}
