using Fff.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Fff.Infrastructure;

public class FffDbContext : DbContext
{
    public FffDbContext(DbContextOptions<FffDbContext> options)
        : base(options) { }

    public DbSet<CustomerDbModel> Customers { get; set; }

    public DbSet<OrderDbModel> Orders { get; set; }

    public DbSet<OrderItemDbModel> OrderItems { get; set; }
}
