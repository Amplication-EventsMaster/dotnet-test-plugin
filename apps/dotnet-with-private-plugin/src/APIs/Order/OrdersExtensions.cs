using DotnetWithPrivatePlugin.APIs.Dtos;
using DotnetWithPrivatePlugin.Infrastructure.Models;

namespace DotnetWithPrivatePlugin.APIs.Extensions;

public static class OrdersExtensions
{
    public static Order ToDto(this OrderDbModel model)
    {
        return new Order
        {
            CreatedAt = model.CreatedAt,
            Date = model.Date,
            Id = model.Id,
            MyCustomer = model.MyCustomerId,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static OrderDbModel ToModel(
        this OrderUpdateInput updateDto,
        OrderWhereUniqueInput uniqueId
    )
    {
        var order = new OrderDbModel { Id = uniqueId.Id, Date = updateDto.Date };

        if (updateDto.CreatedAt != null)
        {
            order.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.MyCustomer != null)
        {
            order.MyCustomerId = updateDto.MyCustomer;
        }
        if (updateDto.UpdatedAt != null)
        {
            order.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return order;
    }
}
