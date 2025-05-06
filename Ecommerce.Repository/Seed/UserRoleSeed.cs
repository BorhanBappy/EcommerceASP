using Ecommerce.Entity.Models;
using Ecommerce.Entity.Models;
using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Repository.Seed;

public class UserRoleSeed
{
    public static async Task SeedData(UserManager<ApplicationUser>? userManager,
        RoleManager<ApplicationRole>? roleManager)
    {
        if (userManager == null || roleManager == null)
        {
            Console.WriteLine("UserManager or RoleManager is null.");
            return;
        }

        // Define the admin role

        const string adminRoleName = "Admin";

        // Check if the admin role exists, and create it if not
        if (!await roleManager.RoleExistsAsync(adminRoleName))
        {
            var adminRole = new ApplicationRole { Name = adminRoleName };
            await roleManager.CreateAsync(adminRole);
        }
        // Define Seller role
        const string sellerRoleName = "Seller";

        // Check if the admin role exists, and create it if not
        if (!await roleManager.RoleExistsAsync(sellerRoleName))
        {
            var adminRole = new ApplicationRole { Name = sellerRoleName };
            await roleManager.CreateAsync(adminRole);
        }
         // Define a clicent role
        const string clientRoleName = "Client";
        // Check if the admin role exists, and create it if not
        if (!await roleManager.RoleExistsAsync(clientRoleName))
        {
            var adminRole = new ApplicationRole { Name = clientRoleName };
            await roleManager.CreateAsync(adminRole);
        }
        // Define the admin user
        const string adminEmail = "admin@example.com";
        const string adminPassword = "Admin@123";

        // Check if the admin user exists, and create it if not
        var adminUser = await userManager.FindByEmailAsync(adminEmail);
        if (adminUser == null)
        {
            adminUser = new ApplicationUser
            {
                UserName = adminEmail,
                Email = adminEmail,
                FirstName = "Admin",
                LastName = "User",
                Address = "Admin Address",
                CreatedAt = DateTime.Now
            };

            var result = await userManager.CreateAsync(adminUser, adminPassword);
            if (result.Succeeded)
            {
                // Assign the admin role to the user
                await userManager.AddToRoleAsync(adminUser, adminRoleName);
            }
            else
            {
                Console.WriteLine("Failed to create admin user: " +
                                  string.Join(", ", result.Errors.Select(e => e.Description)));
            }
        }
    }
}