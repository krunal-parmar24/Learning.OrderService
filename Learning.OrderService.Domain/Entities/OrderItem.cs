namespace Learning.OrderService.Domain.Entities
{
    /// <summary>
    /// Represents an item within an order, including product details, quantity, and price.
    /// </summary>
    public class OrderItem : BaseEntity
    {
        public required int OrderId { get; set; }
        public required int ProductId { get; set; }
        public required int Quantity { get; set; }
        public required decimal Price { get; set; }
        public decimal TotalPrice => Quantity * Price;
        public required Order Order { get; set; }
    }
}
