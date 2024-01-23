using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineClothingStore.Models;

namespace OnlineClothingStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
         public DbSet<OrderDetail> OrderDetails { get; set; }
            public DbSet<Producer> Producers { get; set; }

    }
}