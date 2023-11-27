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
                new Pizza { Id = 1, Name = "Hawajska", Price = 19.99m, Description = "Pizza Hawajska", ImageUrl="" },
                new Pizza { Id = 2, Name = "Capri", Price = 19.99m, Description = "Pizza Capri", ImageUrl = "" },
                new Pizza { Id = 3, Name = "Boczek", Price = 19.99m, Description = "Pizza Boczek", ImageUrl = "" },
                new Pizza { Id = 4, Name = "Margarita", Price = 19.99m, Description = "Pizza margarita", ImageUrl = "" },
                new Pizza { Id = 5, Name = "Cztery Sery", Price = 19.99m, Description = "Pizza Cztery Sery", ImageUrl = "" }
                );
            base.OnModelCreating(modelBuilder);
        }


    }
}