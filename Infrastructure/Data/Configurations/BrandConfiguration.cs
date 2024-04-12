using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                .IsRequired();

            builder.Property(b=>b.Address) 
                .IsRequired();

            builder.Property(b=>b.FoundedYear) 
                .IsRequired();

            builder.Property(b=>b.PhoneNumber)
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}
