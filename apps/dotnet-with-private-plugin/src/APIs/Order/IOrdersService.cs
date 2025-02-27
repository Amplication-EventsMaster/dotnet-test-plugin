using DotnetWithPrivatePlugin.APIs.Common;
using DotnetWithPrivatePlugin.APIs.Dtos;

namespace DotnetWithPrivatePlugin.APIs;

public interface IOrdersService
{
    /// <summary>
    /// Create one order
    /// </summary>
    public Task<Order> CreateOrder(OrderCreateInput order);

    /// <summary>
    /// Delete one order
    /// </summary>
    public Task DeleteOrder(OrderWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many orders
    /// </summary>
    public Task<List<Order>> Orders(OrderFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about order records
    /// </summary>
    public Task<MetadataDto> OrdersMeta(OrderFindManyArgs findManyArgs);

    /// <summary>
    /// Get one order
    /// </summary>
    public Task<Order> Order(OrderWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one order
    /// </summary>
    public Task UpdateOrder(OrderWhereUniqueInput uniqueId, OrderUpdateInput updateDto);

    /// <summary>
    /// Get a my customer record for order
    /// </summary>
    public Task<Customer> GetMyCustomer(OrderWhereUniqueInput uniqueId);
}
