using Microsoft.AspNet.Identity.EntityFramework;

namespace GrupoADyD.Infrastructure.Configurations
{
    public class CustomUserRole : IdentityUserRole<int> { }
    public class CustomUserClaim : IdentityUserClaim<int> { }
    public class CustomUserLogin : IdentityUserLogin<int> { }
}
