using Microsoft.AspNetCore.Mvc;

namespace Fff.APIs;

[ApiController()]
public class CustomersController : CustomersControllerBase
{
    public CustomersController(ICustomersService service)
        : base(service) { }
}
