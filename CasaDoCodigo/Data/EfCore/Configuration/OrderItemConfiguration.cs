using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasaDoCodigo.Data.EfCore.Configuration
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        /// <summary>
        ///     Contains the settings for EF CORE of the properties of the <see cref="OrderItem" /> class.
        /// </summary>
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder
                .ToTable("order_item");

            builder
                .Property(x => x.Id)
                .HasColumnName("id");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Quantity)
                .HasColumnName("quantity")
                .HasColumnType("int")
                .IsRequired();

            builder
                .Property(x => x.UnitPrice)
                .HasColumnName("unit_price")
                .HasColumnType("decimal")
                .HasPrecision(18, 2)
                .IsRequired();

            builder
                .Property("ProductId")
                .HasColumnName("product_id")
                .IsRequired();
        }
    }
}