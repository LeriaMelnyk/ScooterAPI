namespace ScooterDAL.Entities
{
    public class Feedback
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int TripId { get; set; }

        public User User { get; set; }
        public Trip Trip { get; set; }

        public int Rating { get; set; } // від 1 до 5
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
