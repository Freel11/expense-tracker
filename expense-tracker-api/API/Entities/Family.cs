namespace API.Entites;

public class Family
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<AppUser> FamilyMembers { get; set; }
}