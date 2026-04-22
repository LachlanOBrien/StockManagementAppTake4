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
        builder.Entity<ItemLocation>();
        // OrderItem → Item
        builder.Entity<OrderItem>()
            .HasOne(o => o.Item)
            .WithMany(i => i.OrderItems)
            .HasForeignKey(o => o.ItemID)
            .OnDelete(DeleteBehavior.Restrict);

        // OrderItem → Order
        builder.Entity<OrderItem>()
            .HasOne(o => o.Order)
            .WithMany(o => o.OrderItem)
            .HasForeignKey(o => o.OrderID)
            .OnDelete(DeleteBehavior.Cascade);
    }

public DbSet<StockManagementApp.Models.Item> Item { get; set; } = default!;

public DbSet<StockManagementApp.Models.ItemLocation> ItemLocation { get; set; } = default!;

public DbSet<StockManagementApp.Models.Location> Location { get; set; } = default!;

public DbSet<StockManagementApp.Models.Order> Order { get; set; } = default!;

public DbSet<StockManagementApp.Models.Supplier> Supplier { get; set; } = default!;

public DbSet<StockManagementApp.Models.OrderItem> OrderItem { get; set; } = default!;
}
