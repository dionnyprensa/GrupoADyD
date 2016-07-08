using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GrupoADyD.Infrastructure.Configurations
{
    public class CreditNoteConfig : EntityTypeConfiguration<Domain.Entities.CreditNote>
    {
        public CreditNoteConfig()
        {
            ToTable("CreditNotes");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(c => c.Amount)
                .HasPrecision(18, 2)
                .IsRequired();

            Property(ar => ar.Reduction)
                .HasPrecision(18, 2)
                .IsRequired();

            Property(c => c.Authorized)
                .IsRequired();

            Property(c => c.Canceled)
                .IsRequired();

            Property(c => c.SaleId)
                .IsRequired();

            Property(c => c.AuthorizingUserId)
                .IsRequired();

            Property(c => c.CanceledUserId)
                .IsRequired();

            Property(c => c.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}