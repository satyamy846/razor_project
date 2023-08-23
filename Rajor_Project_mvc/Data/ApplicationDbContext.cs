using Microsoft.EntityFrameworkCore;
using Rajor_Project_mvc.Models;

namespace Rajor_Project_mvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Catagory> Catagories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catagory>().HasData(
                new Catagory { Id = 1, Name = "Satyam", DisplayOrder = 2 },
                new Catagory { Id = 2, Name = "Shivam", DisplayOrder = 3 },
                new Catagory { Id = 3, Name = "Deepak", DisplayOrder = 4 }
                );
        }
    }
}
