using DotnetWithPrivatePlugin.Infrastructure;

namespace DotnetWithPrivatePlugin.APIs;

public class OrdersService : OrdersServiceBase
{
    public OrdersService(DotnetWithPrivatePluginDbContext context)
        : base(context) { }
}
