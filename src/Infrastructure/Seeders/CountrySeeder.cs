using CrmApp.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrmApp.Infrastructure.Seeders
{
    public static class CountrySeeder
    {
        public static void SeedCountries(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Türkiye", Code = "TR", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Country { Id = 2, Name = "Almanya", Code = "DE", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Country { Id = 3, Name = "Fransa", Code = "FR", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
        }
    }
}
