using Learning.OrderService.Domain.Enums;

namespace Learning.OrderService.Domain.Entities
{
    /// <summary>
    /// Represents an order placed by a customer, including details such as customer ID, order date, total amount, and status.
    /// </summary>
    public class Order : BaseEntity
    {
        public required int CustomerId { get; set; }
        public required DateTime OrderDate { get; set; }
        public required decimal TotalAmount { get; set; }
        public required OrderStatus Status { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = [];
    }
}
