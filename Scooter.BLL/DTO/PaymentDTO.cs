using System;

namespace Scooter.BLL.DTO
{
    public class PaymentDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TripId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime PaidAt { get; set; }

        public string? UserFullName { get; set; }
        public string? TripDescription { get; set; }
    }
}
