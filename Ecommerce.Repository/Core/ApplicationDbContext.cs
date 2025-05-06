using Ecommerce.Entity.Models;
using Ecommerce.Entity.Models;
using Ecommerce.Repository.Seed;
using Microsoft.EntityFrameworkCore.Diagnostics;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repository.Core;
public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Call the base method to configure Identity entities
        base.OnModelCreating(modelBuilder);

        // Seed data for the Product entity
        modelBuilder.Entity<Product>().HasData(SeedData.Products);
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Orders> Orders { get; set; }
    public DbSet<OrderItems> OrderItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }
}