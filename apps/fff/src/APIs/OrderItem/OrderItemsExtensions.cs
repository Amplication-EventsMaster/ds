using Fff.APIs.Dtos;
using Fff.Infrastructure.Models;

namespace Fff.APIs.Extensions;

public static class OrderItemsExtensions
{
    public static OrderItem ToDto(this OrderItemDbModel model)
    {
        return new OrderItem
        {
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            Order = model.OrderId,
            Quantity = model.Quantity,
            TotalPrice = model.TotalPrice,
            UnitPrice = model.UnitPrice,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static OrderItemDbModel ToModel(
        this OrderItemUpdateInput updateDto,
        OrderItemWhereUniqueInput uniqueId
    )
    {
        var orderItem = new OrderItemDbModel
        {
            Id = uniqueId.Id,
            Quantity = updateDto.Quantity,
            TotalPrice = updateDto.TotalPrice,
            UnitPrice = updateDto.UnitPrice
        };

        if (updateDto.CreatedAt != null)
        {
            orderItem.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.Order != null)
        {
            orderItem.OrderId = updateDto.Order;
        }
        if (updateDto.UpdatedAt != null)
        {
            orderItem.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return orderItem;
    }
}
