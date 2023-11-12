using Microsoft.EntityFrameworkCore;
using PizzaShop.Models;

namespace PizzaShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Pizza> Pizza { get; set; }
    }
}
