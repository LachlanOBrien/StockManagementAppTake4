INSERT INTO Item (SupplierID, ItemName, ItemDescription, Price, MinimumStock)
VALUES 
(3, 'Toothbrush', 'Soft bristle toothbrush', 3.50, 20),
(7, 'Dental Floss', 'Mint flavored floss', 2.20, 30),
(1, 'Mouthwash', 'Alcohol-free mouthwash', 5.99, 15),
(9, 'Toothpaste', 'Whitening toothpaste', 4.75, 25),
(5, 'Gloves', 'Latex examination gloves', 12.00, 50),
(2, 'Face Mask', 'Disposable surgical masks', 8.50, 40),
(10, 'Hand Sanitizer', '70% alcohol sanitizer', 6.25, 35),
(6, 'Cotton Rolls', 'Dental cotton rolls pack', 9.80, 45),
(4, 'Syringes', 'Sterile disposable syringes', 15.00, 60),
(8, 'Disinfectant Wipes', 'Surface cleaning wipes', 7.30, 30);

INSERT INTO ItemLocation (ItemID, SupplierID, LocationID, Quantity)
VALUES
(1, 3, 2, 50),
(2, 7, 5, 30),
(3, 1, 4, 20),
(4, 9, 6, 15),
(5, 2, 3, 60),
(6, 8, 1, 25),
(7, 10, 7, 40),
(8, 4, 8, 35),
(9, 6, 9, 45),
(10, 5, 10, 55);

INSERT INTO Location (LocationName, LocationAddress)
VALUES
('Main Warehouse', '123 Industrial Rd, Auckland'),
('Downtown Storage', '45 Queen St, Auckland'),
('North Depot', '78 North Rd, Auckland'),
('East Facility', '12 East Tamaki Rd, Auckland'),
('West Hub', '99 Lincoln Rd, Auckland'),
('South Storage', '56 Great South Rd, Auckland'),
('Central Clinic Store', '200 Victoria St, Auckland'),
('Harbour Warehouse', '15 Quay St, Auckland'),
('Airport Storage', '8 George Bolt Memorial Dr, Auckland'),
('Suburban Depot', '34 Te Atatu Rd, Auckland');

INSERT INTO [Order] (ItemID, LocationID, SupplierID, OrderName, QuantityOrdered, EstimatedTimeOfArrival, Status)
VALUES
(1, 3, 5, 'Restock Toothbrushes', 100, '2026-04-01',3),
(2, 7, 2, 'Floss Bulk Order', 200, '2026-04-03',3),
(3, 1, 8, 'Mouthwash Shipment', 150, '2026-04-02',3),
(4, 6, 4, 'Toothpaste Refill', 120, '2026-04-05',3),
(5, 2, 9, 'Glove Supply Order', 300, '2026-04-04',3),
(6, 9, 1, 'Mask Restock', 250, '2026-04-06',3),
(7, 4, 7, 'Sanitizer Delivery', 180, '2026-04-07',3),
(8, 8, 3, 'Cotton Rolls Order', 220, '2026-04-08',3),
(9, 5, 6, 'Syringes Batch', 140, '2026-04-09',3),
(10, 10, 10, 'Wipes Replenishment', 160, '2026-04-10',3);

INSERT INTO Supplier (SupplierName, Email, PhoneNumber, Address)
VALUES
('Supplier One', 'Supplier1@supplier1.co.nz', '0215551001', '12 Industry Lane, Auckland'),
('Supplier Two', 'Supplier2@supplier2.com', '0215551002', '45 Health St, Wellington'),
('Supplier Three', 'Supplier3@supplier3.net', '0215551003', '78 Smile Ave, Christchurch'),
('Supplier Four', 'Supplier4@supplier4.co.nz', '0215551004', '34 Care Rd, Hamilton'),
('Supplier Five', 'Supplier5@supplier5.org', '0215551005', '56 Supply Dr, Tauranga'),
('Supplier Six', 'Supplier6@supplier6.co.nz', '0215551006', '22 Market St, Dunedin'),
('Supplier Seven', 'Supplier7@supplier7.com', '0215551007', '10 Harbour View Rd, Auckland'),
('Supplier Eight', 'Supplier8@supplier8.net', '0215551008', '88 Tech Park, Wellington'),
('Supplier Nine', 'Supplier9@supplier9.co.nz', '0215551009', '19 Ocean Rd, Napier'),
('Supplier Ten', 'Supplier10@supplier10.org', '0215551010', '77 South St, Invercargill');