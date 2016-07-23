using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GrupoADyD.Infrastructure.Configurations
{
    class CategoryConfigg : EntityTypeConfiguration<Domain.Entities.Category>
    {
        public CategoryConfigg()
        {
            ToTable("Categories");

            HasKey(a => a.Id);

            Property(a => a.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(a => a.Name)
                .HasColumnType("varchar")
                .HasMaxLength(16)
                .IsRequired();

            Property(a => a.Description)
                .HasColumnType("varchar")
                .HasMaxLength(128)
                .IsRequired();

            Property(a => a.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}
