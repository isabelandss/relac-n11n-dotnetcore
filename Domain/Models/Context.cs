using Microsoft.EntityFrameworkCore;

namespace relacionamento1nn1_api.Domain.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) 
            : base(options) { }

        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<DetailsOrder> DetailsOrder { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Orders>().ToTable("Orders");
            modelBuilder.Entity<Products>().ToTable("Products");
            modelBuilder.Entity<DetailsOrder>().ToTable("Order_Details");

            modelBuilder.Entity<DetailsOrder>()
                .HasKey(c => new { c.OrderID, c.ProductID });
        }

    }
}