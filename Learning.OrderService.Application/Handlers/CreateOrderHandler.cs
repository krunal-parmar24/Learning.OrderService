using Learning.OrderService.Application.Abstractions.ExternalServices;
using Learning.OrderService.Application.Commands;
using MediatR;

namespace Learning.OrderService.Application.Handlers
{
    /// <summary>
    /// Handler for creating a new order
    /// </summary>
    public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, int>
    {
        private readonly IProductServiceClient _productService;

        public CreateOrderHandler(IProductServiceClient productService)
        {
            _productService = productService;
        }

        /// <inheritdoc />
        public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var productIds = request.OrderedItems.Select(item => item.ProductId).ToList();
            var products = await _productService.GetProductsAsync(productIds, cancellationToken);

            Console.WriteLine($"Total {products.Count} Products fetched through Product Service Client");

            // Simulate order creation logic
            int newOrderId = new Random().Next(1000, 9999);
            return newOrderId;
        }
    }
}
