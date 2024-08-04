using Microsoft.AspNetCore.Mvc;

namespace DotnetWithPrivatePlugin.APIs;

[ApiController()]
public class OrdersController : OrdersControllerBase
{
    public OrdersController(IOrdersService service)
        : base(service) { }
}
