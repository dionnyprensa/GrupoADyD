using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace GrupoADyD.Infrastructure.Configurations
{
    public class ProductConfig : EntityTypeConfiguration<Domain.Entities.Product>
    {
        public ProductConfig()
        {
            ToTable("Products");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(c => c.Code)
                .HasColumnType("nvarchar")
                .HasMaxLength(8)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute("Idx_Code", 1) { IsUnique = true }))
                .IsRequired();

            Property(c => c.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(64)
                .IsRequired();

            Property(c => c.Description)
                .HasColumnType("nvarchar")
                .HasMaxLength(32);

            Property(c => c.Cost)
                .HasPrecision(18, 2);

            Property(c => c.Price)
                .HasPrecision(18, 2);

            Property(c => c.Sold);

            Property(p => p.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}