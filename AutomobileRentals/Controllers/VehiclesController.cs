using AutomobileRentals.Contracts;
using AutomobileRentals.EntityFramework.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutomobileRentals.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehiclesController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        // GET: api/Vehicles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehicle()
        {
            var result = await _vehicleService.GetVehicles();
            return Ok(result);
        }

        // GET: api/Vehicles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vehicle>> GetVehicle(int id)
        {
            var vehicle = await _vehicleService.GetVehicle(id);

            if (vehicle == null)
            {
                return NotFound();
            }

            return vehicle;
        }

        // PUT: api/Vehicles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicle(int id, Vehicle vehicle)
        {
            var result = await _vehicleService.PutVehicle(id, vehicle);
            return Ok(result);
        }

        // POST: api/Vehicles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vehicle>> PostVehicle(Vehicle vehicle)
        {
            var result = await _vehicleService.PostVehicle(vehicle);
            return Ok(result);

        }

        // DELETE: api/Vehicles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            var result = await _vehicleService.DeleteVehicle(id);
            return Ok(result);
        }

        [HttpGet, Route("/vehicle-exists")]
         public async Task<bool> VehicleExists(int id)
        {
            var result = await _vehicleService.VehicleExists(id);
            return result;
        }
    }
}
