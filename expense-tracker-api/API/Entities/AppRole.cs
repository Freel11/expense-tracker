using Microsoft.AspNetCore.Identity;

namespace API.Entites;

public class AppRole : IdentityRole<Guid>
{
    public ICollection<AppUserRole> UserRoles { get; set; }
}