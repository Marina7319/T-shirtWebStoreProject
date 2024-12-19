using Microsoft.EntityFrameworkCore;
using T_shirtWebStore.Models;

namespace T_shirtWebStore.Data.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories {  get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Names", DisplayOrder = 3 }
                );

            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Fortune of Time",
                    Description = "Present",
                    ISBN = "SWD9999901",
                    Author = "Billy Spark",
                    Price = 90
                }
                );
        }
    }
}
