using Microsoft.EntityFrameworkCore;
using RazorPizzeria.Models;

namespace RazorPizzeria.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        //protected ApplicationDbContext()
        //{
        //}
    }
}
