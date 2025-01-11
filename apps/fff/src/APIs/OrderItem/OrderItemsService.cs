using Fff.Infrastructure;

namespace Fff.APIs;

public class OrderItemsService : OrderItemsServiceBase
{
    public OrderItemsService(FffDbContext context)
        : base(context) { }
}
