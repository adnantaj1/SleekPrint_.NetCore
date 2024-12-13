using Microsoft.EntityFrameworkCore;
using SleekPrint.Models;

namespace SleekPrint.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> 
            options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Bil Produkter", DisplayOrder = 1},
                new Category { CategoryId = 2, Name = "Sports & Fritid", DisplayOrder = 2 },
                new Category { CategoryId = 3, Name = "Tøj", DisplayOrder = 3 }
                );
        }

    }
}
