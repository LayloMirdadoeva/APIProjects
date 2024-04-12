using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasOne(cart => cart.customer)
                .WithMany()
                .HasForeignKey(cart => cart.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
