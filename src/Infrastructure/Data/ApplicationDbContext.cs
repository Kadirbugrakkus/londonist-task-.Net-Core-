using CrmApp.Core.Entities;
using CrmApp.Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;

namespace CrmApp.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext  // DbContext'ten türemesi sağlandı.
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeders
            CountrySeeder.SeedCountries(modelBuilder);
            UserSeeder.SeedUsers(modelBuilder);

        }
    }
}
