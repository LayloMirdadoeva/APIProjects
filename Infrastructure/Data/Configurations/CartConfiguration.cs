using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(cart => cart.Id);
            builder.Property(cart => cart.Number)
                .IsRequired();
            builder.Property(cart => cart.ValidityPeriod)
                .IsRequired();
            builder.Property(cart => cart.CodeCVV)
                .IsRequired();
        }
    }
}
