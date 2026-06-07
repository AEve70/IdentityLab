using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace IdentityLab.Api.identity;

public class LabIdentityDbContextFactory
    : IDesignTimeDbContextFactory<LabIdentityDbContext>
{
    public LabIdentityDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<LabIdentityDbContext>();

        optionsBuilder.UseSqlServer(
            "Server=localhost,1434;Database=IdentityDB;User Id=sa;Password=MiClaveSegura123*;TrustServerCertificate=True;");

        return new LabIdentityDbContext(optionsBuilder.Options);
    }
}