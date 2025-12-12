using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Learning.OrderService.Infrastructure.Data
{
    /// <summary>
    /// Provides a design-time factory for creating instances of OrderContext for EF Core tools.
    /// </summary>
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<OrderContext>
    {
        public OrderContext CreateDbContext(string[] args)
        {
            // Navigate to API project directory to find appsettings.json
            var basePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "Learning.OrderService.API");

            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.Development.json", optional: true)
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<OrderContext>();
            optionsBuilder.UseNpgsql(connectionString);

            return new OrderContext(optionsBuilder.Options);
        }
    }
}
