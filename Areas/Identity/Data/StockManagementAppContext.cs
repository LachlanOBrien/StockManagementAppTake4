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

        // Item → Supplier
        builder.Entity<Item>()
            .HasOne(i => i.Supplier)
            .WithMany(s => s.Item)
            .HasForeignKey(i => i.SupplierID)
            .OnDelete(DeleteBehavior.Restrict);

        // ItemLocation → Item
        builder.Entity<ItemLocation>()
            .HasOne(il => il.Item)
            .WithMany(i => i.ItemLocation)
            .HasForeignKey(il => il.ItemID)
            .OnDelete(DeleteBehavior.Restrict);

        // ItemLocation → Supplier
        builder.Entity<ItemLocation>()
            .HasOne(il => il.Supplier)
            .WithMany(s => s.ItemLocation)
            .HasForeignKey(il => il.SupplierID)
            .OnDelete(DeleteBehavior.Restrict);

        // ItemLocation → Location
        builder.Entity<ItemLocation>()
            .HasOne(il => il.Location)
            .WithMany(l => l.ItemLocations)
            .HasForeignKey(il => il.LocationID)
            .OnDelete(DeleteBehavior.Restrict);

        // Order → Item
        builder.Entity<Order>()
            .HasOne(o => o.Item)
            .WithMany(i => i.Order)
            .HasForeignKey(o => o.ItemID)
            .OnDelete(DeleteBehavior.Restrict);

        // Order → Supplier
        builder.Entity<Order>()
            .HasOne(o => o.Supplier)
            .WithMany(s => s.Order)
            .HasForeignKey(o => o.SupplierID)
            .OnDelete(DeleteBehavior.Restrict);

        // Order → Location
        builder.Entity<Order>()
            .HasOne(o => o.Location)
            .WithMany(l => l.Orders)
            .HasForeignKey(o => o.LocationID)
            .OnDelete(DeleteBehavior.Restrict);
    }

public DbSet<StockManagementApp.Models.Item> Item { get; set; } = default!;

public DbSet<StockManagementApp.Models.ItemLocation> ItemLocation { get; set; } = default!;

public DbSet<StockManagementApp.Models.Location> Location { get; set; } = default!;

public DbSet<StockManagementApp.Models.Order> Order { get; set; } = default!;

public DbSet<StockManagementApp.Models.Supplier> Supplier { get; set; } = default!;
}
