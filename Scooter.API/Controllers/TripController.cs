using Microsoft.AspNetCore.Mvc;
using Scooter.BLL.DTO;
using Scooter.BLL.Services.Interfaces;
using Scooter.DAL.Pagination;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Scooter.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TripController : ControllerBase
    {
        private readonly ITripService _tripService;

        public TripController(ITripService tripService)
        {
            _tripService = tripService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TripDTO>>> GetAllTrips()
        {
            var trips = await _tripService.GetAllTripsWithDetailsAsync();
            return Ok(trips);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TripDTO>> GetTrip(int id)
        {
            var trip = await _tripService.GetTripByIdAsync(id);
            if (trip == null)
                return NotFound();

            return Ok(trip);
        }

 
        [HttpPost]
        public async Task<ActionResult> CreateTrip([FromBody] TripDTO tripDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _tripService.CreateTripAsync(tripDto);
            return CreatedAtAction(nameof(GetTrip), new { id = tripDto.Id }, tripDto);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateTrip(int id, [FromBody] TripDTO tripDto)
        {
            if (id != tripDto.Id)
                return BadRequest("Id в URL і тілі не збігаються");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingTrip = await _tripService.GetTripByIdAsync(id);
            if (existingTrip == null)
                return NotFound();

            await _tripService.UpdateTripAsync(tripDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTrip(int id)
        {
            var existingTrip = await _tripService.GetTripByIdAsync(id);
            if (existingTrip == null)
                return NotFound();

            await _tripService.DeleteTripAsync(id);
            return NoContent();
        }

        [HttpGet("paged")]
        public async Task<IActionResult> GetTrips(int pageNumber = 1, int pageSize = 10)
        {
            var trips = await _tripService.GetTripsAsync(pageNumber, pageSize);
            return Ok(trips);
        }

    }

}
