using Microsoft.AspNetCore.Identity;

namespace API.Entites;

public class AppUserRole : IdentityUserRole<Guid>
{
    public AppUser User { get; set; }
    public AppRole Role { get; set; }
}