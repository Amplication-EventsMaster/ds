using Fff.Infrastructure;

namespace Fff.APIs;

public class OrdersService : OrdersServiceBase
{
    public OrdersService(FffDbContext context)
        : base(context) { }
}
