using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GrupoADyD.Infrastructure.Configurations
{
    public class ProductMeasureConfig : EntityTypeConfiguration<Domain.Entities.ProductMeasure>
    {
        public ProductMeasureConfig()
        {
            ToTable("ProductMeasures");

            HasKey(a => a.Id);

            Property(a => a.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(c => c.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(64)
                .IsRequired();

            Property(c => c.Description)
                .HasColumnType("nvarchar")
                .HasMaxLength(64);

            Property(pm => pm.QuantityByUnitMesuare)
                .IsRequired();

            Property(s => s.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}