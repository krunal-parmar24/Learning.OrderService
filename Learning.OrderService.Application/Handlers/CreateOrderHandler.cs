using Learning.OrderService.Application.Commands;
using MediatR;

namespace Learning.OrderService.Application.Handlers
{
    /// <summary>
    /// Handler for creating a new order
    /// </summary>
    public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, int>
    {
        /// <inheritdoc />
        public Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            // Simulate order creation logic
            int newOrderId = new Random().Next(1000, 9999);
            return Task.FromResult(newOrderId);
        }
    }
}
