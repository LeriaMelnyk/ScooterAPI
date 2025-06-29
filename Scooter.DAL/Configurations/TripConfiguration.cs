using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScooterDAL.Entities;

namespace ScooterDAL.Entities.Configurations
{
    public class TripConfiguration : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.StartLocation)
                   .HasMaxLength(150);

            builder.Property(t => t.EndLocation)
                   .HasMaxLength(150);

            builder.HasOne(t => t.User)
                   .WithMany(u => u.Trips)
                   .HasForeignKey(t => t.UserId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Vehicle)
                   .WithMany(v => v.Trips)
                   .HasForeignKey(t => t.VehicleId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Payment)
                   .WithOne(p => p.Trip)
                   .HasForeignKey<Payment>(p => p.TripId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.Feedback)
                   .WithOne(f => f.Trip)
                   .HasForeignKey<Feedback>(f => f.TripId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
