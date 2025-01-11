using Fff.Infrastructure;

namespace Fff.APIs;

public class CustomersService : CustomersServiceBase
{
    public CustomersService(FffDbContext context)
        : base(context) { }
}
