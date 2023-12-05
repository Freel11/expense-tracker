using Microsoft.AspNetCore.Identity;

namespace API.Entites;

public class AppUser : IdentityUser<Guid>
{
    public ICollection<AppUserRole> UserRoles { get; set; }
    // public Family Family { get; set; }
    // public Guid? FamilyId { get; set; }
}