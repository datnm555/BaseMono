using Microsoft.AspNetCore.Identity;

namespace BaseMono.Entities.Models;

public abstract class User : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    
}