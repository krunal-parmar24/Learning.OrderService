namespace Learning.OrderService.Domain.Enums
{
    /// <summary>
    /// Specifies the possible statuses for an order in the order processing workflow.
    /// </summary>
    public enum OrderStatus
    {
        Pending = 0,
        Confirmed = 1,
        Failed = 2,
        Canceled = 3,
    }
}
