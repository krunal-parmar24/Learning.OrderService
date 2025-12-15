using Learning.OrderService.Application.DTOs;

namespace Learning.OrderService.Application.Abstractions.ExternalServices
{
    /// <summary>
    /// Interface for interacting with the Product Service to perform specified operations.
    /// </summary>
    public interface IProductServiceClient
    {
        /// <summary>
        /// Fetch products by their IDs from the Product Service.
        /// </summary>
        /// <param name="productIds">List of product Id</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Returns details of requested products</returns>
        Task<List<ProductDto>> GetProductsAsync(List<int> productIds, CancellationToken ct);
    }
}
