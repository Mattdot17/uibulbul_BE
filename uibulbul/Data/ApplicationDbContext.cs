using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using uibulbul.Models;

namespace uibulbul.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Currency> Currencies { get; set; }

        public ApplicationDbContext() : base()
        { 
            Database.EnsureCreated();
        }

    }
}
