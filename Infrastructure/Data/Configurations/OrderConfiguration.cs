using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Quantity)
                .IsRequired();
            builder.Property(o=>o.Status)
                .IsRequired();
            builder.Property(o=>o.Amount)
                .HasColumnType("decimal(18, 2)")
                .IsRequired();

            builder.Property(o => o.TotalPrice)
               .HasColumnType("decimal(18, 2)")
               .IsRequired();
            builder.Property(o=>o.Date)
                .IsRequired();
          
            builder.HasOne(o => o.Products)
                .WithMany(p => p.Orders)
                .HasForeignKey(o=>o.ProductId)
                .OnDelete(DeleteBehavior.Cascade); 

            builder.HasOne(o => o.Customers)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(o => o.Diliverys)
                .WithMany(d => d.Orders)
                .HasForeignKey(o => o.DiliveryId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
