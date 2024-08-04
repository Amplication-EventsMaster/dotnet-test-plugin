using DotnetWithPrivatePlugin.APIs;
using Microsoft.AspNetCore.Mvc;

namespace DotnetWithPrivatePlugin.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CustomersControllerBase : ControllerBase
{
    protected readonly ICustomersService _service;

    public CustomersControllerBase(ICustomersService service)
    {
        _service = service;
    }
}
