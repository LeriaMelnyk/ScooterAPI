using Microsoft.AspNetCore.Mvc;
using Scooter.BLL.DTO;
using Scooter.BLL.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Scooter.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentDTO>>> GetAll()
        {
            var payments = await _paymentService.GetAllPaymentsAsync();
            return Ok(payments);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentDTO>> GetById(int id)
        {
            var payment = await _paymentService.GetPaymentByIdAsync(id);
            if (payment == null)
                return NotFound();

            return Ok(payment);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] PaymentDTO paymentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _paymentService.CreatePaymentAsync(paymentDto);
            return CreatedAtAction(nameof(GetById), new { id = paymentDto.Id }, paymentDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] PaymentDTO paymentDto)
        {
            if (id != paymentDto.Id)
                return BadRequest("Id в URL і в тілі не збігаються");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingPayment = await _paymentService.GetPaymentByIdAsync(id);
            if (existingPayment == null)
                return NotFound();

            await _paymentService.UpdatePaymentAsync(paymentDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existingPayment = await _paymentService.GetPaymentByIdAsync(id);
            if (existingPayment == null)
                return NotFound();

            await _paymentService.DeletePaymentAsync(id);
            return NoContent();
        }

        [HttpGet("user/{userId}")]
        public async Task<ActionResult<IEnumerable<PaymentDTO>>> GetUserPayments(int userId)
        {
            var payments = await _paymentService.GetUserPaymentsAsync(userId);
            return Ok(payments);
        }

        [HttpGet("user/{userId}/total")]
        public async Task<ActionResult<decimal>> GetUserTotalPaid(int userId)
        {
            var total = await _paymentService.GetUserTotalPaidAsync(userId);
            return Ok(total);
        }
    }

}
