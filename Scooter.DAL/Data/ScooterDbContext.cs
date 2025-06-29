using Microsoft.EntityFrameworkCore;
using ScooterDAL.Entities;
using ScooterDAL.Data;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ScooterDAL.Data
{
    public class ScooterDbContext:DbContext
    {
        public ScooterDbContext(DbContextOptions<ScooterDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ScooterDbContext).Assembly);
            SeedData.SeedDatao(modelBuilder);
        }
}
}
