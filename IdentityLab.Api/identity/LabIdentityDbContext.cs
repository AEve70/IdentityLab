using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace IdentityLab.Api.identity;

public class LabIdentityDbContext(DbContextOptions<LabIdentityDbContext> options) : IdentityDbContext<User, UserRole, string>(options)
{

}





