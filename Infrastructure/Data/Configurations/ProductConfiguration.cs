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
                 .HasColumnType("decimal(18, 2)")
                .IsRequired();

            builder.Property(p => p.Size)
                .IsRequired();

            builder.Property(p => p.Color)
                .IsRequired();
            

            builder.Property(p => p.PricePerPiece)
                 .HasColumnType("decimal(18, 2)")
                
                .IsRequired();
            builder.HasOne( p => p.Categorys)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Brands)
                .WithMany(b => b.Products)
                .HasForeignKey(p => p.BrandId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
