using DotnetWithPrivatePlugin.Infrastructure.Models;
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

    public DbSet<CustomerDbModel> Customers { get; set; }

    public DbSet<OrderDbModel> Orders { get; set; }
}
