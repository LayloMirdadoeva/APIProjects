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
                .IsRequired();  
            builder.Property(o=>o.Date)
                .IsRequired();
            builder.Property(o=>o.CustomerId)
                .IsRequired();
            builder.Property(o => o.ProductId)
                .IsRequired();
            builder.Property(o => o.DiliveryId)
                .IsRequired();
        }
    }
}
