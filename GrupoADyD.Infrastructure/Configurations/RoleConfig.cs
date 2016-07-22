using System.Data.Entity.ModelConfiguration;

namespace GrupoADyD.Infrastructure.Configurations
{
    public class RoleConfig : EntityTypeConfiguration<Domain.Entities.Role>
    {
        public RoleConfig()
        {
            ToTable("Roles");

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
                    m.ToTable("RolesAccess");
                    m.MapLeftKey("RoleId");
                    m.MapRightKey("AccessId");
                });

            Property(r => r.RowVersion)
                .HasColumnType("timestamp");
        }
    }
}