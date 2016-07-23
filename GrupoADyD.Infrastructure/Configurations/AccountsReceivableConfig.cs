using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GrupoADyD.Infrastructure.Configurations
{
    public class AccountsReceivableConfig : EntityTypeConfiguration<Domain.Entities.AccountsReceivable>
    {
        public AccountsReceivableConfig()
        {
            ToTable("AccountsReceivable");

            HasKey(ar => ar.Id);

            Property(ar => ar.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(ar => ar.Amount)
                .HasPrecision(18, 2)
                .IsRequired();

            HasRequired(ar => ar.Sale)
                .WithRequiredPrincipal(s => s.AccountsReceivable);

            HasMany(ar => ar.DetailsAccountsReceivable)
                .WithRequired(dar => dar.AccountsReceivable)
                .HasForeignKey(a => a.AccountsReceivableId);

            Property(a => a.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}