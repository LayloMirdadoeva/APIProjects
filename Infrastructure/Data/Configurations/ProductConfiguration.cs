using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Price)
                .HasPrecision(10, 2)
                .IsRequired();

            builder.Property(p => p.Size)
                .IsRequired();

            builder.Property(p=>p.Color)
                .IsRequired();

            builder.Property(p => p.Brand)
                .IsRequired();

            builder.Property(p=>p.PricePerPiece)
                .HasPrecision (10, 2)
                .IsRequired();

            //builder.HasOne(p => p.Brand)
            //    .WithMany(b => b.Products)

        }
    }
}
