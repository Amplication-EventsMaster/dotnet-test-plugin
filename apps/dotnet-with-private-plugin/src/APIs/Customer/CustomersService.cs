using DotnetWithPrivatePlugin.Infrastructure;

namespace DotnetWithPrivatePlugin.APIs;

public class CustomersService : CustomersServiceBase
{
    public CustomersService(DotnetWithPrivatePluginDbContext context)
        : base(context) { }
}
