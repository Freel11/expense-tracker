using API.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext: IdentityDbContext<AppUser, AppRole, Guid, 
    IdentityUserClaim<Guid>, AppUserRole, IdentityUserLogin<Guid>, 
    IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    /*public DbSet<Family> Families { get; set; }*/

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.Entity<AppUser>()
            .HasMany(ur => ur.UserRoles)
            .WithOne(u => u.User)
            .HasForeignKey(ur => ur.UserId)
            .IsRequired();
        
        builder.Entity<AppRole>()
            .HasMany(ur => ur.UserRoles)
            .WithOne(u => u.Role)
            .HasForeignKey(ur => ur.RoleId)
            .IsRequired();

        builder.Entity<Family>()
            .HasKey(f => f.Id);

        builder.Entity<Family>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();

        /*builder.Entity<Family>()
            .HasMany(f => f.FamilyMembers)
            .WithOne(u => u.Family)
            .HasForeignKey(ur => ur.FamilyId);*/
    }
}