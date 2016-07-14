using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GrupoADyD.Infrastructure.Configurations
{
    internal class DetailAccountReceivableConfig : EntityTypeConfiguration<Domain.Entities.DetailAccountsReceivable>
    {
        public DetailAccountReceivableConfig()
        {
            ToTable("DetailAccountsReceivable");

            HasKey(d => d.Id);

            Property(d => d.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(d => d.AccountsReceivableId)
                .IsRequired();

            Property(d => d.Due)
                .HasPrecision(18, 2)
                .IsRequired();

            Property(d => d.Paid)
                .HasPrecision(18, 2)
                .IsRequired();
        }
    }
}