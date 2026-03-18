using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StockManagementApp.Areas.Identity.Data;
using StockManagementApp.Models;

namespace StockManagementApp.Areas.Identity.Data;

public class StockManagementAppContext : IdentityDbContext<StockManagementAppUser>
{
    public StockManagementAppContext(DbContextOptions<StockManagementAppContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<StockManagementApp.Models.Item> Item { get; set; } = default!;

public DbSet<StockManagementApp.Models.ItemLocation> ItemLocation { get; set; } = default!;

public DbSet<StockManagementApp.Models.Location> Location { get; set; } = default!;

public DbSet<StockManagementApp.Models.Order> Order { get; set; } = default!;

public DbSet<StockManagementApp.Models.Supplier> Supplier { get; set; } = default!;
}
