using System;

namespace Scooter.BLL.DTO
{
    public class FeedbackDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TripId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        public string? UserFullName { get; set; }
    }
}
