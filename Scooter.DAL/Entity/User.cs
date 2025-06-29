namespace ScooterDAL.Entities
{
    public class User
    {

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool IsVerified { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<Trip> Trips { get; set; }
        public ICollection<Payment> Payments { get; set; }

    }
}
