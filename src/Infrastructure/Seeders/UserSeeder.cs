using CrmApp.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CrmApp.Infrastructure.Seeders
{
    public static class UserSeeder
    {
        public static void SeedUsers(this ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<User>();

            modelBuilder.Entity<User>().HasData(
                new User { 
                    Id = 1,
                    Name = "Admin",
                    Email = "admin@test.com",
                    Password = hasher.HashPassword(null!, "123456"),
                    Username = "admin",
                    CreatedAt = DateTime.UtcNow,
                    DeletedAt = null,
                    UpdatedAt = DateTime.UtcNow 
                }
            );
        }
    }
}
