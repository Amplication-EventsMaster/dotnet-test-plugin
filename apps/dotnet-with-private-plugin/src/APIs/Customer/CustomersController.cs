using Microsoft.AspNetCore.Mvc;

namespace DotnetWithPrivatePlugin.APIs;

[ApiController()]
public class CustomersController : CustomersControllerBase
{
    public CustomersController(ICustomersService service)
        : base(service) { }
}
