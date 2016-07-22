using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GrupoADyD.Infrastructure.Configurations
{
    public class ProductRegistryConfig : EntityTypeConfiguration<Domain.Entities.ProductRegistry>
    {
        public ProductRegistryConfig()
        {
            ToTable("ProductRegistries");

            HasKey(pr => pr.Id);

            Property(pr => pr.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(pr => pr.Quantity)
                .IsRequired();

            Property(pr => pr.Date)
                .IsRequired();

            Property(pr => pr.ProductId)
                .IsRequired();

            Property(pr => pr.ProductMeasureId)
                .IsRequired();

            Property(pr => pr.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}