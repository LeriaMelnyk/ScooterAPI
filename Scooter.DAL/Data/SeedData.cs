using Microsoft.EntityFrameworkCore;
using ScooterDAL.Entities;
using System;

namespace ScooterDAL.Data
{
    public class SeedData
    {
        public static void SeedDatao(ModelBuilder modelBuilder)
        {
            // Users
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FullName = "Alice Johnson", Email = "alice@example.com", PasswordHash = "hash1", IsVerified = true, CreatedAt = new DateTime(2025, 6, 1, 8, 0, 0, DateTimeKind.Utc) },
                new User { Id = 2, FullName = "Bob Smith", Email = "bob@example.com", PasswordHash = "hash2", IsVerified = false, CreatedAt = new DateTime(2025, 6, 2, 8, 0, 0, DateTimeKind.Utc) },
                new User { Id = 3, FullName = "Charlie Brown", Email = "charlie@example.com", PasswordHash = "hash3", IsVerified = true, CreatedAt = new DateTime(2025, 6, 3, 8, 0, 0, DateTimeKind.Utc) },
                new User { Id = 4, FullName = "Diana Prince", Email = "diana@example.com", PasswordHash = "hash4", IsVerified = true, CreatedAt = new DateTime(2025, 6, 4, 8, 0, 0, DateTimeKind.Utc) },
                new User { Id = 5, FullName = "Ethan Hunt", Email = "ethan@example.com", PasswordHash = "hash5", IsVerified = false, CreatedAt = new DateTime(2025, 6, 5, 8, 0, 0, DateTimeKind.Utc) }
            );

            // Vehicles
            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle { Id = 1, Type = "Scooter", Model = "Xiaomi M365", RegistrationNumber = "SC-001", IsAvailable = true, CurrentLocation = "Center Park", BatteryLevel = 85, LastServiceDate = new DateTime(2025, 6, 18, 10, 0, 0, DateTimeKind.Utc) },
                new Vehicle { Id = 2, Type = "Bike", Model = "Giant Escape", RegistrationNumber = "BK-002", IsAvailable = true, CurrentLocation = "Main Street", BatteryLevel = 100, LastServiceDate = new DateTime(2025, 6, 8, 10, 0, 0, DateTimeKind.Utc) },
                new Vehicle { Id = 3, Type = "Scooter", Model = "Segway Ninebot", RegistrationNumber = "SC-003", IsAvailable = true, CurrentLocation = "Old Town", BatteryLevel = 75, LastServiceDate = new DateTime(2025, 6, 23, 10, 0, 0, DateTimeKind.Utc) },
                new Vehicle { Id = 4, Type = "Bike", Model = "Trek FX", RegistrationNumber = "BK-004", IsAvailable = true, CurrentLocation = "River Side", BatteryLevel = 100, LastServiceDate = new DateTime(2025, 6, 13, 10, 0, 0, DateTimeKind.Utc) },
                new Vehicle { Id = 5, Type = "Scooter", Model = "E-Twow GT", RegistrationNumber = "SC-005", IsAvailable = false, CurrentLocation = "Depot", BatteryLevel = 45, LastServiceDate = new DateTime(2025, 6, 26, 10, 0, 0, DateTimeKind.Utc) }
            );

            // Trips
            modelBuilder.Entity<Trip>().HasData(
                new Trip { Id = 1, UserId = 1, VehicleId = 1, StartTime = new DateTime(2025, 6, 25, 8, 0, 0, DateTimeKind.Utc), EndTime = new DateTime(2025, 6, 25, 8, 15, 0, DateTimeKind.Utc), StartLocation = "Center Park", EndLocation = "Main Square", DistanceKm = 2.5, TotalPrice = 3.50m },
                new Trip { Id = 2, UserId = 2, VehicleId = 2, StartTime = new DateTime(2025, 6, 26, 9, 0, 0, DateTimeKind.Utc), EndTime = new DateTime(2025, 6, 26, 9, 20, 0, DateTimeKind.Utc), StartLocation = "Main Street", EndLocation = "Old Town", DistanceKm = 3.1, TotalPrice = 4.00m },
                new Trip { Id = 3, UserId = 3, VehicleId = 3, StartTime = new DateTime(2025, 6, 27, 10, 0, 0, DateTimeKind.Utc), EndTime = new DateTime(2025, 6, 27, 10, 10, 0, DateTimeKind.Utc), StartLocation = "Old Town", EndLocation = "River Side", DistanceKm = 1.8, TotalPrice = 2.80m },
                new Trip { Id = 4, UserId = 4, VehicleId = 4, StartTime = new DateTime(2025, 6, 28, 15, 0, 0, DateTimeKind.Utc), EndTime = new DateTime(2025, 6, 28, 15, 30, 0, DateTimeKind.Utc), StartLocation = "River Side", EndLocation = "Depot", DistanceKm = 4.2, TotalPrice = 5.20m },
                new Trip { Id = 5, UserId = 5, VehicleId = 5, StartTime = new DateTime(2025, 6, 29, 17, 0, 0, DateTimeKind.Utc), EndTime = new DateTime(2025, 6, 29, 18, 15, 0, DateTimeKind.Utc), StartLocation = "Depot", EndLocation = "Center Park", DistanceKm = 3.6, TotalPrice = 4.70m }
            );

            // Payments
            modelBuilder.Entity<Payment>().HasData(
                new Payment { Id = 1, UserId = 1, TripId = 1, Amount = 3.50m, PaymentMethod = "Card", PaidAt = new DateTime(2025, 6, 25, 8, 30, 0, DateTimeKind.Utc) },
                new Payment { Id = 2, UserId = 2, TripId = 2, Amount = 4.00m, PaymentMethod = "PayPal", PaidAt = new DateTime(2025, 6, 26, 9, 30, 0, DateTimeKind.Utc) },
                new Payment { Id = 3, UserId = 3, TripId = 3, Amount = 2.80m, PaymentMethod = "Card", PaidAt = new DateTime(2025, 6, 27, 10, 30, 0, DateTimeKind.Utc) },
                new Payment { Id = 4, UserId = 4, TripId = 4, Amount = 5.20m, PaymentMethod = "Card", PaidAt = new DateTime(2025, 6, 28, 15, 45, 0, DateTimeKind.Utc) },
                new Payment { Id = 5, UserId = 5, TripId = 5, Amount = 4.70m, PaymentMethod = "PayPal", PaidAt = new DateTime(2025, 6, 29, 18, 30, 0, DateTimeKind.Utc) }
            );

            // Feedbacks
            modelBuilder.Entity<Feedback>().HasData(
                new Feedback { Id = 1, UserId = 1, TripId = 1, Rating = 5, Comment = "Great ride!", CreatedAt = new DateTime(2025, 6, 25, 8, 45, 0, DateTimeKind.Utc) },
                new Feedback { Id = 2, UserId = 2, TripId = 2, Rating = 4, Comment = "Smooth and easy.", CreatedAt = new DateTime(2025, 6, 26, 9, 45, 0, DateTimeKind.Utc) },
                new Feedback { Id = 3, UserId = 3, TripId = 3, Rating = 5, Comment = "Loved it!", CreatedAt = new DateTime(2025, 6, 27, 10, 45, 0, DateTimeKind.Utc) },
                new Feedback { Id = 4, UserId = 4, TripId = 4, Rating = 3, Comment = "Okay ride.", CreatedAt = new DateTime(2025, 6, 28, 15, 50, 0, DateTimeKind.Utc) },
                new Feedback { Id = 5, UserId = 5, TripId = 5, Rating = 4, Comment = "Very good!", CreatedAt = new DateTime(2025, 6, 29, 18, 45, 0, DateTimeKind.Utc) }
            );
        }
    }
}
