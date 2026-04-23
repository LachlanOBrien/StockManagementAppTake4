using StockManagementApp.Models;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StockManagementApp.Areas.Identity.Data
{
    public class DbInitializer
    {
        public static void Initialize(StockManagementAppContext context)
        {
            // Apply any pending migrations and create the database if it does not exist.
            // Using Migrate() is preferred when the project uses EF Core migrations.
            context.Database.Migrate();

            // Look for any products.
            if (context.Item.Any())
            {
                return;   // DB has been seeded
            }

            var Supplier = new Supplier[]
            {
                new Supplier { SupplierName="Supplier One", Email="Supplier1@supplier1.co.nz", PhoneNumber=0215551001, Address="12 Industry Lane, Auckland"},
                new Supplier { SupplierName="Supplier Two", Email="Supplier2@supplier2.com", PhoneNumber=0215551002, Address="45 Health St, Wellington"},
                new Supplier { SupplierName="Supplier Three", Email="Supplier3@supplier3.net", PhoneNumber=0215551003, Address="78 Smile Ave, Christchurch"},
                new Supplier { SupplierName="Supplier Four", Email="Supplier4@supplier4.co.nz", PhoneNumber=0215551004, Address="34 Care Rd, Hamilton"},
                new Supplier { SupplierName="Supplier Five", Email="Supplier5@supplier5.org", PhoneNumber=0215551005, Address="56 Supply Dr, Tauranga"},
                new Supplier { SupplierName="Supplier Six", Email="Supplier6@supplier6.co.nz", PhoneNumber=0215551006, Address="22 Market St, Dunedin"},
                new Supplier { SupplierName="Supplier Seven", Email="Supplier7@supplier7.com", PhoneNumber=0215551007, Address="10 Harbour View Rd, Auckland"},
                new Supplier { SupplierName="Supplier Eight", Email="Supplier8@supplier8.net", PhoneNumber=0215551008, Address="88 Tech Park, Wellington"},
                new Supplier { SupplierName="Supplier Nine", Email="Supplier9@supplier9.co.nz", PhoneNumber=0215551009, Address="19 Ocean Rd, Napier"},
                new Supplier { SupplierName="Supplier Ten", Email="Supplier10@supplier10.org", PhoneNumber=0215551010, Address="77 South St, Invercargill"}
            };

            foreach (Supplier S in Supplier)
            {
                context.Supplier.Add(S);
            }
            context.SaveChanges();


            var Location = new Location[]
            {
                new Location { LocationName="Main Warehouse", LocationAddress="123 Industrial Rd, Auckland"},
                new Location { LocationName="Downtown Storage", LocationAddress="45 Queen St, Auckland"},
                new Location { LocationName="North Depot", LocationAddress="78 North Rd, Auckland"},
                new Location { LocationName="East Facility", LocationAddress="12 East Tamaki Rd, Auckland"},
                new Location { LocationName="West Hub", LocationAddress="99 Lincoln Rd, Auckland"},
                new Location { LocationName="South Storage", LocationAddress="56 Great South Rd, Auckland"},
                new Location { LocationName="Central Clinic Store", LocationAddress="200 Victoria St, Auckland"},
                new Location { LocationName="Harbour Warehouse", LocationAddress="15 Quay St, Auckland"},
                new Location { LocationName="Airport Storage", LocationAddress="8 George Bolt Memorial Dr, Auckland"},
                new Location { LocationName="Suburban Depot", LocationAddress="34 Te Atatu Rd, Auckland"}
            };

            foreach (Location L in Location)
            {
                context.Location.Add(L);
            }
            context.SaveChanges();


            var Items = new Item[]
            {
                new Item{SupplierID=3, ItemName="Toothbrush", ItemDescription="Soft bristle toothbrush", Price=(int)3.50, MinimumStock=20},
                new Item{SupplierID=7, ItemName="Dental Floss", ItemDescription="Mint flavored floss", Price=(int)2.20, MinimumStock=30},
                new Item{SupplierID=1, ItemName="Mouthwash", ItemDescription="Alcohol-free mouthwash", Price=(int)5.99, MinimumStock=15},
                new Item{SupplierID=9, ItemName="Toothpaste", ItemDescription="Whitening toothpaste", Price=(int)4.75, MinimumStock=25},
                new Item{SupplierID=5, ItemName="Gloves", ItemDescription="Latex examination gloves", Price=(int)12.00, MinimumStock=50},
                new Item{SupplierID=2, ItemName="Face Mask", ItemDescription="Disposable surgical masks", Price=(int)8.50, MinimumStock=40},
                new Item{SupplierID=10, ItemName="Hand Sanitizer", ItemDescription="70% alcohol sanitizer", Price=(int)6.25, MinimumStock=35},
                new Item{SupplierID=6, ItemName="Cotton Rolls", ItemDescription="Dental cotton rolls pack", Price=(int)9.80, MinimumStock=45},
                new Item{SupplierID=4, ItemName="Syringes", ItemDescription="Sterile disposable syringes", Price=(int)15.00, MinimumStock=60},
                new Item{SupplierID=8, ItemName="Disinfectant Wipes", ItemDescription="Surface cleaning wipes", Price=(int)7.30, MinimumStock=30}
            };

            foreach (Item I in Items)
            {
                context.Item.Add(I);
            }
            context.SaveChanges();


            var ItemLocation = new ItemLocation[]
            {
                new ItemLocation{ItemID=3, SupplierID=3, LocationID=2, Quantity=50},
                new ItemLocation{ItemID=2, SupplierID=7, LocationID=5, Quantity=30},
                new ItemLocation{ItemID=1, SupplierID=1, LocationID=4, Quantity=20},
                new ItemLocation{ItemID=4, SupplierID=9, LocationID=6, Quantity=15},
                new ItemLocation{ItemID=6, SupplierID=2, LocationID=3, Quantity=60},
                new ItemLocation{ItemID=10, SupplierID=8, LocationID=1, Quantity=25},
                new ItemLocation{ItemID=7, SupplierID=10, LocationID=7, Quantity=40},
                new ItemLocation{ItemID=9, SupplierID=4, LocationID=8, Quantity=35},
                new ItemLocation{ItemID=8, SupplierID=6, LocationID=9, Quantity=45},
                new ItemLocation{ItemID=5, SupplierID=5, LocationID=10, Quantity=55}
            };

            foreach (ItemLocation IL in ItemLocation)
            {
                context.ItemLocation.Add(IL);
            }
            context.SaveChanges();


            var Order = new Order[]
            {
    new Order{EstimatedTimeOfArrival = DateTime.Parse("2026-04-01"), Status = 0, OrderName="Restock Toothbrushes"},
    new Order{EstimatedTimeOfArrival = DateTime.Parse("2026-04-03"), Status = 0, OrderName="Floss Bulk Order"},
    new Order{EstimatedTimeOfArrival = DateTime.Parse("2026-04-02"), Status = 0, OrderName="Mouthwash Shipment"},
    new Order{EstimatedTimeOfArrival = DateTime.Parse("2026-04-05"), Status = 0, OrderName="Toothpaste Refill"},
    new Order{EstimatedTimeOfArrival = DateTime.Parse("2026-04-04"), Status = 0, OrderName="Glove Supply Order"},
    new Order{EstimatedTimeOfArrival = DateTime.Parse("2026-04-06"), Status = 0, OrderName="Mask Restock"},
    new Order{EstimatedTimeOfArrival = DateTime.Parse("2026-04-07"), Status = 0, OrderName="Sanitizer Delivery"},
    new Order{EstimatedTimeOfArrival = DateTime.Parse("2026-04-08"), Status = 0, OrderName="Cotton Rolls Order"},
    new Order{EstimatedTimeOfArrival = DateTime.Parse("2026-04-09"), Status = 0, OrderName="Syringes Batch"},
    new Order{EstimatedTimeOfArrival = DateTime.Parse("2026-04-10"), Status = 0, OrderName="Wipes Replenishment"}
            };

            foreach (Order O in Order)
            {
                context.Order.Add(O);
            }
            context.SaveChanges();

            var OrderItem = new OrderItem[]
            {
    new OrderItem{ItemID = 3, QuantityOrdered = 100, OrderID = 1},
    new OrderItem{ItemID = 6, QuantityOrdered = 100, OrderID = 2},
                new OrderItem{ItemID = 10, QuantityOrdered = 150, OrderID = 3},
                new OrderItem{ItemID = 9, QuantityOrdered = 120, OrderID = 4},
                new OrderItem{ItemID = 4, QuantityOrdered = 300, OrderID = 5},
                new OrderItem{ItemID = 3, QuantityOrdered = 250, OrderID = 6},
                new OrderItem{ItemID = 2, QuantityOrdered = 180, OrderID = 7},
                new OrderItem{ItemID = 1, QuantityOrdered = 220, OrderID = 8},
                new OrderItem{ItemID = 8, QuantityOrdered = 140, OrderID = 9},
                new OrderItem{ItemID = 7, QuantityOrdered = 160, OrderID = 10}
            };

            foreach (OrderItem OI in OrderItem)
            {
                context.OrderItem.Add(OI);
            }
            context.SaveChanges();

        }
    }
}