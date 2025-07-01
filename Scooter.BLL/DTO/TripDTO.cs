using System;

namespace Scooter.BLL.DTO
{
    public class TripDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int VehicleId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public double DistanceKm { get; set; }
        public decimal TotalPrice { get; set; }

        public string? UserFullName { get; set; }
        public string? VehicleModel { get; set; }
    }
}
