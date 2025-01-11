using Microsoft.AspNetCore.Mvc;

namespace Fff.APIs;

[ApiController()]
public class OrdersController : OrdersControllerBase
{
    public OrdersController(IOrdersService service)
        : base(service) { }
}
