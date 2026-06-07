using Microsoft.AspNetCore.Identity;
namespace IdentityLab.Api;

public class User : IdentityUser
{
    public string FullName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
}
