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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().HasData(
                new Pizza { Id = 1, Name = "Hawajska", Description = "Pizza Hawajska" },
                new Pizza { Id = 2, Name = "Capri", Description = "Pizza Capri" },
                new Pizza { Id = 3, Name = "Boczek", Description = "Pizza Boczek" },
                new Pizza { Id = 3, Name = "Margarita", Description = "Pizza margarita" },
                new Pizza { Id = 3, Name = "Cztery Sery", Description = "Pizza Cztery Sery" }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}