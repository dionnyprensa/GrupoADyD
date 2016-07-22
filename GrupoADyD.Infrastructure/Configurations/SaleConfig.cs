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

            Property(s => s.CustomerId)
                .IsRequired();

            Property(s => s.UserId)
                .IsRequired();

            //HasRequired(s => s.Client)
            //    .WithMany(c => c.Purchases);

            //HasRequired(s => s.User)
            //    .WithMany(c => c.Sales);

            Property(s => s.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}