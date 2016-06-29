using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GrupoADyD.Infrastructure.Configurations
{
    public class ClientConfig : EntityTypeConfiguration<Domain.Entities.Client>
    {
        public ClientConfig()
        {
            ToTable("Clients");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(c => c.FirstName)
                .HasColumnType("nvarchar")
                .HasMaxLength(64)
                .IsRequired();

            Property(c => c.LastName)
                .HasColumnType("nvarchar")
                .HasMaxLength(32);

            Property(c => c.Phone)
                .HasColumnType("nvarchar")
                .HasMaxLength(10);

            Property(c => c.Address)
                .HasColumnType("nvarchar")
                .HasMaxLength(64);

            Property(c => c.Discount)
                .HasPrecision(18, 2);

            Property(c => c.ToCost);

            Property(c => c.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}