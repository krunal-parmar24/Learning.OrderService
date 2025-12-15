using Learning.OrderService.Application.Abstractions.ExternalServices;
using Learning.OrderService.Application.DTOs;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace Learning.OrderService.Infrastructure.ExternalServices.Products
{
    /// <summary>
    /// Http client implementation for interacting with the Product Service.
    /// </summary>
    public class ProductServiceHttpClient : IProductServiceClient
    {
        private readonly HttpClient _httpClient;

        public ProductServiceHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <inheritdoc />
        public async Task<List<ProductDto>> GetProductsAsync(List<int> productIds, CancellationToken ct)
        {
            var response = await _httpClient.GetAsync($"/api/v1/products?productIds={string.Join(",", productIds)}", ct);

            response.EnsureSuccessStatusCode();

            var products = await response.Content.ReadFromJsonAsync<List<ProductDto>>(ct);

            return products ?? [];
        }
    }
}
