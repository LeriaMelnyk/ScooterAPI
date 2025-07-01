namespace ScooterDAL.Entities
{
    public class Payment
    {
        public int Id { get; set; }

        // FK
        public int UserId { get; set; }
        public int TripId { get; set; }

        // Навігація
        public User User { get; set; }
        public Trip Trip { get; set; }

        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } // Напр. "Card", "PayPal"
        public DateTime PaidAt { get; set; }
    }

}
