using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GrupoADyD.Infrastructure.Configurations
{
    public class SaleConfig : EntityTypeConfiguration<Domain.Entities.Sale>
    {
        public SaleConfig()
        {
            ToTable("Sales");

            HasKey(a => a.Id);

            Property(a => a.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(d => d.Discount)
                .HasPrecision(18, 2)
                .IsRequired();

            Property(a => a.Total)
                .HasPrecision(18, 2)
                .IsRequired();

            //HasRequired(s => s.Client)
            //    .WithMany(c => c.Purchases);

            //HasRequired(s => s.User)
            //    .WithMany(c => c.Sales);

            Property(s => s.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}