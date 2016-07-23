using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GrupoADyD.Infrastructure.Configurations
{
    public class CreditNoteConfig : EntityTypeConfiguration<Domain.Entities.CreditNote>
    {
        public CreditNoteConfig()
        {
            ToTable("CreditNotes");

            HasKey(cn => cn.Id);

            Property(cn => cn.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(cn => cn.Amount)
                .HasPrecision(18, 2)
                .IsRequired();

            Property(cn => cn.Authorized)
                .IsRequired();

            Property(cn => cn.Canceled)
                .IsRequired();

            HasRequired(cn => cn.Sale)
                 .WithRequiredPrincipal(s => s.CreditNote);

            HasRequired(cn => cn.ApprovedBy)
                .WithMany(u => u.CreditNote)
                .HasForeignKey(cnu => cnu.ApprovedById);

            HasOptional(cn => cn.CanceledBy)
                .WithMany(u => u.CreditNote)
                .HasForeignKey(cn => cn.CanceledById);

            Property(cn => cn.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}