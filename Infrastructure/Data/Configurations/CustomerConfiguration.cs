using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(cus => cus.Id);
            builder.Property(cus => cus.FullName)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(cus => cus.Address)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(cus => cus.Password)
                .IsRequired();
            builder.Property(cus => cus.PhoneNumber)
                .IsRequired();
            builder.Property(cus => cus.Email)
                .IsRequired();

        }
    }
}
