using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GrupoADyD.Infrastructure.Configurations
{
    public class CustomerConfig : EntityTypeConfiguration<Domain.Entities.Customer>
    {
        public CustomerConfig()
        {
            ToTable("Customers");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(c => c.FirstName)
                .HasColumnType("nvarchar")
                .HasMaxLength(32)
                .IsRequired();

            Property(c => c.LastName)
                .HasColumnType("nvarchar")
                .HasMaxLength(64)
                .IsRequired();

            Property(c => c.Address)
                .HasColumnType("nvarchar")
                .HasMaxLength(128)
                .IsOptional();

            Property(c => c.Phone)
                .HasColumnType("nvarchar")
                .HasMaxLength(10)
                .IsRequired();

            Property(c => c.Email)
                .HasColumnType("nvarchar")
                .HasMaxLength(64)
                .IsOptional();

            Property(c => c.Discount)
                .HasPrecision(18, 2)
                .IsOptional();

            Property(c => c.OnCredit)
                .IsOptional();

            Property(c => c.HasAccountsReceivable)
                .IsOptional();

            Property(c => c.HasCreditNotes)
                .IsOptional();

            Property(c => c.CustomerType)
                .IsRequired();

            Property(c => c.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}