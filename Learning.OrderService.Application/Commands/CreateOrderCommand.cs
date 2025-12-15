using Learning.OrderService.Application.DTOs;
using Learning.OrderService.Domain.Enums;
using MediatR;

namespace Learning.OrderService.Application.Commands
{
    /// <summary>
    /// Command to create a new order
    /// </summary>
    /// <param name="CustomerId">Unique Customer Identifier</param>
    /// <param name="OrderedItems">List of Ordered Items</param>
    /// <param name="PaymentMethod">Selected Payment Method</param>
    public record CreateOrderCommand(int CustomerId, List<OrderItemDto> OrderedItems, PaymentMethod PaymentMethod) : IRequest<int>;
}
