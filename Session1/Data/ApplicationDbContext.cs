using Microsoft.EntityFrameworkCore;
using Session1.Models;

namespace Session1.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=MVC12;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Ahmad 1", Description = "Description for Ahmad 1" },
                new Category { Id = 2, Name = "Ahmad 2", Description = "Description for Ahmad 2" },
                new Category { Id = 3, Name = "Ahmad 3", Description = "Description for Ahmad 3" },
                new Category { Id = 4, Name = "Ahmad 4", Description = "Description for Ahmad 4" }
            );
        }
    }
}
