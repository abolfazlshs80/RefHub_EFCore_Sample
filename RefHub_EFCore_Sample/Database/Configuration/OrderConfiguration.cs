using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefHub_EFCore_Sample.Database.Model;
using RefHub_EFCore_Sample.Database.ValueConvertor;

namespace RefHub_EFCore_Sample.Database.Configuration
{
    public class OrderConfiguration: IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(a => new { a.OrderId, });


            builder.HasMany(a => a.OrderItem)
                .WithOne(a => a.Order)
                .HasForeignKey(a => a.OrderId);

            builder.HasOne(a => a.UserAddress)
                .WithMany()
                .HasForeignKey(a => a.UserAddressId);

            builder.HasOne(a => a.User)
                .WithMany(o => o.Order)
                .HasForeignKey(a => a.UserId);
            builder
                .Property(o => o.Status)
                .HasConversion(new OrderStatusConverter());
        }
    }
}
