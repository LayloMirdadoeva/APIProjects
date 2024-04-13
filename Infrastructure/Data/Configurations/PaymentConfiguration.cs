using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Status)
                .IsRequired();
            builder.Property(x => x.Method)
               .IsRequired();
         
            builder.Property(x => x.Amount)
               .IsRequired();
            builder.Property(x => x.Date)
               .IsRequired();
            builder.HasOne(x => x.Orders)
                .WithMany(o => o.Payments)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.Cascade);
       
        }
    }
}
