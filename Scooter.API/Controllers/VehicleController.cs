using Microsoft.AspNetCore.Mvc;
using Scooter.BLL.DTO;
using Scooter.BLL.Services.Interfaces;

namespace ScooterAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehiclesController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VehicleDTO>>> GetAll()
        {
            var vehicles = await _vehicleService.GetAllVehiclesAsync();
            return Ok(vehicles);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VehicleDTO>> GetById(int id)
        {
            var vehicle = await _vehicleService.GetVehicleByIdAsync(id);
            if (vehicle == null)
                return NotFound();

            return Ok(vehicle);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] VehicleDTO vehicleDto)
        {
            if (vehicleDto == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _vehicleService.CreateVehicleAsync(vehicleDto);
            return CreatedAtAction(nameof(GetById), new { id = vehicleDto.Id }, vehicleDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] VehicleDTO vehicleDto)
        {
            if (vehicleDto == null || vehicleDto.Id != id)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                await _vehicleService.UpdateVehicleAsync(vehicleDto);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _vehicleService.DeleteVehicleAsync(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpGet("available")]
        public async Task<ActionResult<IEnumerable<VehicleDTO>>> GetAvailable()
        {
            var vehicles = await _vehicleService.GetAvailableVehiclesAsync();
            return Ok(vehicles);
        }

        [HttpGet("by-registration/{regNumber}")]
        public async Task<ActionResult<VehicleDTO>> GetByRegistrationNumber(string regNumber)
        {
            var vehicle = await _vehicleService.GetByRegistrationNumberAsync(regNumber);
            if (vehicle == null)
                return NotFound();

            return Ok(vehicle);
        }
    }

}
