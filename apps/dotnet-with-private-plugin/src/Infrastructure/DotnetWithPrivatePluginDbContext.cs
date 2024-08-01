using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotnetWithPrivatePlugin.Infrastructure;

public class DotnetWithPrivatePluginDbContext : IdentityDbContext<IdentityUser>
{
    public DotnetWithPrivatePluginDbContext(
        DbContextOptions<DotnetWithPrivatePluginDbContext> options
    )
        : base(options) { }
}
