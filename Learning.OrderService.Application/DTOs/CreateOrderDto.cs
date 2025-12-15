using Learning.OrderService.Domain.Enums;

namespace Learning.OrderService.Application.DTOs
{
    /// <summary>
    /// Dto for creating a new order
    /// </summary>
    /// <param name="CustomerId">Customer Unique Identifier</param>
    /// <param name="OrderItems">List of Order Items with Product Id and purchased quantities</param>
    /// <param name="Method">Selected Payment Method</param>
    public record CreateOrderDto(int CustomerId, List<OrderItemDto> OrderItems, PaymentMethod Method);

    /// <summary>
    /// Dto for Order Item
    /// </summary>
    /// <param name="ProductId">Product Unique Identifier</param>
    /// <param name="Quantity">Number of Quantity requested to purchase</param>
    public record OrderItemDto(int ProductId, int Quantity);
}
