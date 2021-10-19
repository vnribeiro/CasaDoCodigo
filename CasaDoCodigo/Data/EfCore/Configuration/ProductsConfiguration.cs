using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasaDoCodigo.Data.EfCore.Configuration
{
    public class ProductsConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .ToTable("product");

            builder
                .Property(x => x.Id)
                .HasColumnName("id");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Code)
                .HasColumnName("code")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .HasIndex(x => x.Code)
                .IsUnique();

            builder
                .Property(x => x.Name)
                .HasColumnName("name")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(x => x.Price)
                .HasColumnName("price")
                .HasColumnType("decimal")
                .HasPrecision(18, 2)
                .IsRequired();

            builder
                .HasOne(x => x.Category);
        }
    }
}