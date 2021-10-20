using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasaDoCodigo.Data.EfCore.Configuration
{
    public class RegisterConfiguration : IEntityTypeConfiguration<Register>
    {
        /// <summary>
        ///     Contains the settings for EF CORE of the properties of the <see cref="Register" /> class.
        /// </summary>
        public void Configure(EntityTypeBuilder<Register> builder)
        {
            builder
                .ToTable("register");

            builder
                .Property(x => x.Id)
                .HasColumnName("id");

            builder
                .HasIndex(x => x.Id);

            builder
                .Property(x => x.Name)
                .HasColumnName("name")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(x => x.Email)
                .HasColumnName("email")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(x => x.Phone)
                .HasColumnName("phone")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(x => x.Complement)
                .HasColumnName("complement")
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder
                .Property(x => x.Address)
                .HasColumnName("address")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(x => x.District)
                .HasColumnName("district")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(x => x.Uf)
                .HasColumnName("uf")
                .HasColumnType("char(2)")
                .IsRequired();

            builder
                .Property(x => x.Cep)
                .HasColumnName("cep")
                .HasColumnType("varchar(25)")
                .IsRequired();
        }
    }
}