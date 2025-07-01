namespace ScooterDAL.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; } // "Scooter" або "Bike"
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public bool IsAvailable { get; set; }
        public string CurrentLocation { get; set; }
        public int BatteryLevel { get; set; }
        public DateTime LastServiceDate { get; set; }

        // Навігаційна властивість
        public ICollection<Trip> Trips { get; set; }
    }

}
