using Fff.APIs.Common;
using Fff.APIs.Dtos;

namespace Fff.APIs;

public interface IOrderItemsService
{
    /// <summary>
    /// Create one Order Item
    /// </summary>
    public Task<OrderItem> CreateOrderItem(OrderItemCreateInput orderitem);

    /// <summary>
    /// Delete one Order Item
    /// </summary>
    public Task DeleteOrderItem(OrderItemWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Order Items
    /// </summary>
    public Task<List<OrderItem>> OrderItems(OrderItemFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Order Item records
    /// </summary>
    public Task<MetadataDto> OrderItemsMeta(OrderItemFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Order Item
    /// </summary>
    public Task<OrderItem> OrderItem(OrderItemWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Order Item
    /// </summary>
    public Task UpdateOrderItem(OrderItemWhereUniqueInput uniqueId, OrderItemUpdateInput updateDto);

    /// <summary>
    /// Get a Order record for Order Item
    /// </summary>
    public Task<Order> GetOrder(OrderItemWhereUniqueInput uniqueId);
}
