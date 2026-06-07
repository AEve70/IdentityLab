using Microsoft.AspNetCore.Identity;

namespace IdentityLab.Api;

public class UserRole : IdentityRole
{
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}
