using System.Data.Entity.ModelConfiguration;

namespace GrupoADyD.Infrastructure.Configurations
{
    public class UserConfig : EntityTypeConfiguration<Domain.Entities.User>
    {
        public UserConfig()
        {
            //ToTable("Users");

            HasKey(u => u.Id);

            //Property(u => u.Id)
            //    .HasColumnType("int")
            //    .HasColumnName("Id")
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(u => u.FirstName)
                .HasMaxLength(64)
                .IsRequired();

            Property(u => u.LastName)
                .HasMaxLength(32);

            Property(u => u.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}