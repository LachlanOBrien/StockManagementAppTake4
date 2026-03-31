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

        // Configure relationships explicitly to avoid multiple cascade paths in SQL Server.
        builder.Entity<Item>()
            .HasOne(i => i.Supplier)
            .WithMany(s => s.Item)
            .HasForeignKey(i => i.SupplierID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<ItemLocation>()
            .HasOne(il => il.Item)
            .WithMany(i => i.ItemLocation)
            .HasForeignKey(il => il.ItemID)
            .OnDelete(DeleteBehavior.Cascade);

        // Prevent a second cascade path from Supplier -> ItemLocation (direct) and Supplier -> Item -> ItemLocation (via Item)
        builder.Entity<ItemLocation>()
            .HasOne(il => il.Supplier)
            .WithMany(s => s.ItemLocation)
            .HasForeignKey(il => il.SupplierID)
            .OnDelete(DeleteBehavior.Restrict);

        // Keep Order relationships cascading as desired (adjust if needed):
        builder.Entity<Order>()
            .HasOne(o => o.Supplier)
            .WithMany(s => s.Order)
            .HasForeignKey(o => o.SupplierID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Order>()
            .HasOne(o => o.Location)
            .WithMany(l => l.Orders)
            .HasForeignKey(o => o.LocationID)
            .OnDelete(DeleteBehavior.Cascade);
    }

public DbSet<StockManagementApp.Models.Item> Item { get; set; } = default!;

public DbSet<StockManagementApp.Models.ItemLocation> ItemLocation { get; set; } = default!;

public DbSet<StockManagementApp.Models.Location> Location { get; set; } = default!;

public DbSet<StockManagementApp.Models.Order> Order { get; set; } = default!;

public DbSet<StockManagementApp.Models.Supplier> Supplier { get; set; } = default!;
}
