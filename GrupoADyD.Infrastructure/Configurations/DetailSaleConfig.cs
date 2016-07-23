using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GrupoADyD.Infrastructure.Configurations
{
    public class DetailSaleConfig : EntityTypeConfiguration<Domain.Entities.DetailSale>
    {
        public DetailSaleConfig()
        {
            ToTable("DetailsSales");

            HasKey(d => d.Id);

            Property(d => d.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(d => d.Quantity)
                .IsRequired();

            Property(d => d.SaleId)
                .IsRequired();

            Property(d => d.ProductId)
                .IsRequired();

            //HasRequired(d => d.Sale)
            //    .WithRequiredPrincipal(s => s.DetailedSale);

            //HasRequired(d => d.Product)
            //    .WithMany(p => p.DetailSales);
            //.HasForeignKey(s => s.ProductId);
        }
    }
}