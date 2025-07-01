using Microsoft.AspNetCore.Mvc;
using Scooter.BLL.DTO;
using Scooter.BLL.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Scooter.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackService _feedbackService;

        public FeedbackController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FeedbackDTO>>> GetAll()
        {
            var feedbacks = await _feedbackService.GetAllFeedbacksAsync();
            return Ok(feedbacks);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FeedbackDTO>> GetById(int id)
        {
            var feedback = await _feedbackService.GetFeedbackByIdAsync(id);
            if (feedback == null)
                return NotFound();

            return Ok(feedback);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] FeedbackDTO feedbackDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _feedbackService.CreateFeedbackAsync(feedbackDto);
            return CreatedAtAction(nameof(GetById), new { id = feedbackDto.Id }, feedbackDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] FeedbackDTO feedbackDto)
        {
            if (id != feedbackDto.Id)
                return BadRequest("Id в URL і в тілі не збігаються");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = await _feedbackService.GetFeedbackByIdAsync(id);
            if (existing == null)
                return NotFound();

            await _feedbackService.UpdateFeedbackAsync(feedbackDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existing = await _feedbackService.GetFeedbackByIdAsync(id);
            if (existing == null)
                return NotFound();

            await _feedbackService.DeleteFeedbackAsync(id);
            return NoContent();
        }

        [HttpGet("details")]
        public async Task<ActionResult<IEnumerable<FeedbackDTO>>> GetAllWithDetails()
        {
            var feedbacks = await _feedbackService.GetAllWithDetailsAsync();
            return Ok(feedbacks);
        }

        [HttpGet("average")]
        public async Task<ActionResult<double>> GetAverageRating()
        {
            var avg = await _feedbackService.GetAverageRatingAsync();
            return Ok(avg);
        }

        [HttpGet("trip/{tripId}")]
        public async Task<ActionResult<IEnumerable<FeedbackDTO>>> GetTripFeedbacks(int tripId)
        {
            var feedbacks = await _feedbackService.GetTripFeedbacksAsync(tripId);
            return Ok(feedbacks);
        }
    }

}
