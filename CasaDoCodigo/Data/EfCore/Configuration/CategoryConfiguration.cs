using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasaDoCodigo.Data.EfCore.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        /// <summary>
        ///     Contains the settings for EF CORE of the properties of the <see cref="Category" /> class.
        /// </summary>
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .ToTable("category");

            builder
                .Property(x => x.Id)
                .HasColumnName("id");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .HasColumnName("name")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .HasIndex(x => x.Name)
                .IsUnique();
        }
    }
}