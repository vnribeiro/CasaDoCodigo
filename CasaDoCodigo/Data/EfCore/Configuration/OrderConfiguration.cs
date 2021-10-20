using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasaDoCodigo.Data.EfCore.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        /// <summary>
        ///     Contains the settings for EF CORE of the properties of the <see cref="Order" /> class.
        /// </summary>
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
                .ToTable("order");

            builder
                .Property(x => x.Id)
                .HasColumnName("id");

            builder
                .HasIndex(x => x.Id);

            builder
                .HasMany(x => x.Items)
                .WithOne(x => x.Order)
                .HasForeignKey("order_id")
                .IsRequired();

            builder
                .HasOne(x => x.Register)
                .WithOne(x => x.Order)
                .HasForeignKey<Register>("order_id")
                .IsRequired();
        }
    }
}