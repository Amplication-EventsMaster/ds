using Fff.APIs.Dtos;
using Fff.Infrastructure.Models;

namespace Fff.APIs.Extensions;

public static class CustomersExtensions
{
    public static Customer ToDto(this CustomerDbModel model)
    {
        return new Customer
        {
            Address = model.Address,
            CreatedAt = model.CreatedAt,
            DateOfBirth = model.DateOfBirth,
            Email = model.Email,
            FirstName = model.FirstName,
            Id = model.Id,
            IsActive = model.IsActive,
            LastName = model.LastName,
            Orders = model.Orders?.Select(x => x.Id).ToList(),
            PhoneNumber = model.PhoneNumber,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static CustomerDbModel ToModel(
        this CustomerUpdateInput updateDto,
        CustomerWhereUniqueInput uniqueId
    )
    {
        var customer = new CustomerDbModel
        {
            Id = uniqueId.Id,
            Address = updateDto.Address,
            DateOfBirth = updateDto.DateOfBirth,
            Email = updateDto.Email,
            FirstName = updateDto.FirstName,
            IsActive = updateDto.IsActive,
            LastName = updateDto.LastName,
            PhoneNumber = updateDto.PhoneNumber
        };

        if (updateDto.CreatedAt != null)
        {
            customer.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            customer.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return customer;
    }
}
