namespace ScooterDAL.Entities
{
    public class Trip
    {
        public int Id { get; set; }

        // Зовнішні ключі
        public int UserId { get; set; }
        public int VehicleId { get; set; }

        // Навігаційні властивості
        public User User { get; set; }
        public Vehicle Vehicle { get; set; }

        // Деталі поїздки
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public double DistanceKm { get; set; }
        public decimal TotalPrice { get; set; }

        public Payment Payment { get; set; }
        public Feedback Feedback { get; set; }
    }

}
