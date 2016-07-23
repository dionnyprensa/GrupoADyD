using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GrupoADyD.Infrastructure.Configurations
{
    public class SaleConfig : EntityTypeConfiguration<Domain.Entities.Sale>
    {
        public SaleConfig()
        {
            ToTable("Sales");

            HasKey(s => s.Id);

            Property(s => s.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(s => s.Discount)
                .HasPrecision(18, 2);

            Property(s => s.SubTotal)
                .HasPrecision(18, 2)
                .IsRequired();

            Property(s => s.Total)
                .HasPrecision(18, 2)
                .IsRequired();

            Property(s => s.Paid)
                .HasPrecision(18, 2)
                .IsRequired();

            Property(s => s.Due)
                .HasPrecision(18, 2)
                .IsOptional();

            HasRequired(s => s.Customer)
                .WithMany(c => c.Purchases)
                .HasForeignKey(s => s.CustomerId);

            HasRequired(s => s.User)
                .WithMany(u => u.Sales)
                .HasForeignKey(s => s.UserId);

            HasRequired(s => s.CanceledBy)
                .WithMany(u => u.Sales)
                .HasForeignKey(s => s.UserId);

            HasRequired(s => s.AccountsReceivable)
                .WithRequiredPrincipal(ar => ar.Sale);

            Property(s => s.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}