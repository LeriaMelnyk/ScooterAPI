using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScooterDAL.Entities;

namespace ScooterDAL.Entities.Configurations
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(v => v.Id);

            builder.Property(v => v.Type)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(v => v.Model)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(v => v.RegistrationNumber)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasIndex(v => v.RegistrationNumber)
                   .IsUnique();

            builder.Property(v => v.CurrentLocation)
                   .HasMaxLength(150);

            builder.Property(v => v.BatteryLevel)
                   .IsRequired();

            builder.Property(v => v.LastServiceDate)
                   .IsRequired();
        }
    }
}
