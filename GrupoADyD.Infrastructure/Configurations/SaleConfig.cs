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

            Property(s => s.TypePurchase)
                .IsRequired();

            Property(s => s.PaymentMethod)
                .IsRequired();

            Property(s => s.StatusEntity)
                .IsRequired();

            HasRequired(s => s.Customer)
                .WithMany(c => c.Purchases)
                .HasForeignKey(s => s.CustomerId);

            HasRequired(s => s.CreatedBy)
                .WithMany(u => u.Sales)
                .HasForeignKey(s => s.CreatedById);

            HasRequired(s => s.ModifiedBy)
                .WithMany(u => u.Sales)
                .HasForeignKey(s => s.ModifiedById);

            Property(s => s.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}