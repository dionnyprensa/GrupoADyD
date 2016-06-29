using System.Data.Entity.ModelConfiguration;

namespace GrupoADyD.Infrastructure.Configurations
{
    public class RoleConfig : EntityTypeConfiguration<Domain.Entities.Role>
    {
        public RoleConfig()
        {
            //ToTable("AspNetRoles");

            HasKey(a => a.Id);

            //Property(a => a.Id)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
            //    .HasColumnName("Id");

            Property(a => a.Name)
                .HasColumnType("varchar")
                .IsRequired();

            Property(a => a.Description)
                .HasMaxLength(128)
                .HasColumnType("varchar")
                .IsRequired();

            HasMany(r => r.Access)
                .WithMany(a => a.Roles)
                .Map(m =>
                {
                    m.ToTable("AspNetRolesAccess");
                    m.MapLeftKey("RoleId");
                    m.MapRightKey("AccessId");
                });

            Property(r => r.RowVersion)
                .HasColumnType("timestamp");
        }
    }
}