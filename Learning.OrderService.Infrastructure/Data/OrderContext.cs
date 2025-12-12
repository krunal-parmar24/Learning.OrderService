using Learning.OrderService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Learning.OrderService.Infrastructure.Data
{
    /// <summary>
    /// Represents the database context for the Order Service, managing entities such as Orders and OrderItems.
    /// </summary>
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
