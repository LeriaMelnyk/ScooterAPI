using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScooterDAL.Entities;

namespace ScooterDAL.Entities.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Amount)
                   .IsRequired()
                   .HasColumnType("decimal(10,2)");

            builder.Property(p => p.PaymentMethod)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(p => p.PaidAt)
                   .IsRequired();

            builder.HasOne(p => p.User)
                   .WithMany(u => u.Payments)
                   .HasForeignKey(p => p.UserId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
