using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasaDoCodigo.Data.EfCore.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
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
                .HasMany(x => x.Items);

            builder
                .HasOne(x => x.Register);
        }
    }
}