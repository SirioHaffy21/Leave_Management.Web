using Leave_Management.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Leave_Management.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();

            builder.HasData(
                new Employee
                {
                    Id = "408aa945-3d84-4421-8342-7269ec64d949",
                    Email = "Admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Abc@123")
                },
                new Employee
                {
                    Id = "3f4631bd-f907-4409-b416-ba356131e659",
                    Email = "user@example.com",
                    NormalizedEmail = "USER@EXAMPLE.COM",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "Abc@123")
                }
            );
        }
    }
}