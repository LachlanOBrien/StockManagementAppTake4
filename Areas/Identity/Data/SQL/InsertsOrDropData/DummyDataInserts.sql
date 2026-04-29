--INSERT INTO Item (SupplierID, ItemName, ItemDescription, Price, MinimumStock)
--VALUES 
--(3, 'Toothbrush', 'Soft bristle toothbrush', 3.50, 20),
--(7, 'Dental Floss', 'Mint flavored floss', 2.20, 30),
--(1, 'Mouthwash', 'Alcohol-free mouthwash', 5.99, 15),
--(9, 'Toothpaste', 'Whitening toothpaste', 4.75, 25),
--(5, 'Gloves', 'Latex examination gloves', 12.00, 50),
--(2, 'Face Mask', 'Disposable surgical masks', 8.50, 40),
--(10, 'Hand Sanitizer', '70% alcohol sanitizer', 6.25, 35),
--(6, 'Cotton Rolls', 'Dental cotton rolls pack', 9.80, 45),
--(4, 'Syringes', 'Sterile disposable syringes', 15.00, 60),
--(8, 'Disinfectant Wipes', 'Surface cleaning wipes', 7.30, 30);

--INSERT INTO ItemLocation (ItemID, SupplierID, LocationID, Quantity)
--VALUES
--(1, 3, 2, 50),
--(2, 7, 5, 30),
--(3, 1, 4, 20),
--(4, 9, 6, 15),
--(5, 2, 3, 60),
--(6, 8, 1, 25),
--(7, 10, 7, 40),
--(8, 4, 8, 35),
--(9, 6, 9, 45),
--(10, 5, 10, 55);

--INSERT INTO Location (LocationName, LocationAddress)
--VALUES
--('Main Warehouse', '123 Industrial Rd, Auckland'),
--('Downtown Storage', '45 Queen St, Auckland'),
--('North Depot', '78 North Rd, Auckland'),
--('East Facility', '12 East Tamaki Rd, Auckland'),
--('West Hub', '99 Lincoln Rd, Auckland'),
--('South Storage', '56 Great South Rd, Auckland'),
--('Central Clinic Store', '200 Victoria St, Auckland'),
--('Harbour Warehouse', '15 Quay St, Auckland'),
--('Airport Storage', '8 George Bolt Memorial Dr, Auckland'),
--('Suburban Depot', '34 Te Atatu Rd, Auckland');

--INSERT INTO [Order] (ItemID, LocationID, SupplierID, OrderName, QuantityOrdered, EstimatedTimeOfArrival, Status)
--VALUES
--(1, 3, 5, 'Restock Toothbrushes', 100, '2026-04-01',0),
--(2, 7, 2, 'Floss Bulk Order', 200, '2026-04-03',0),
--(3, 1, 8, 'Mouthwash Shipment', 150, '2026-04-02',0),
--(4, 6, 4, 'Toothpaste Refill', 120, '2026-04-05',0),
--(5, 2, 9, 'Glove Supply Order', 300, '2026-04-04',0),
--(6, 9, 1, 'Mask Restock', 250, '2026-04-06',0),
--(7, 4, 7, 'Sanitizer Delivery', 180, '2026-04-07',0),
--(8, 8, 3, 'Cotton Rolls Order', 220, '2026-04-08',0),
--(9, 5, 6, 'Syringes Batch', 140, '2026-04-09',0),
--(10, 10, 10, 'Wipes Replenishment', 160, '2026-04-10',0);

--INSERT INTO Supplier (SupplierName, Email, PhoneNumber, Address)
--VALUES
--('Supplier One', 'Supplier1@supplier1.co.nz', '0215551001', '12 Industry Lane, Auckland'),
--('Supplier Two', 'Supplier2@supplier2.com', '0215551002', '45 Health St, Wellington'),
--('Supplier Three', 'Supplier3@supplier3.net', '0215551003', '78 Smile Ave, Christchurch'),
--('Supplier Four', 'Supplier4@supplier4.co.nz', '0215551004', '34 Care Rd, Hamilton'),
--('Supplier Five', 'Supplier5@supplier5.org', '0215551005', '56 Supply Dr, Tauranga'),
--('Supplier Six', 'Supplier6@supplier6.co.nz', '0215551006', '22 Market St, Dunedin'),
--('Supplier Seven', 'Supplier7@supplier7.com', '0215551007', '10 Harbour View Rd, Auckland'),
--('Supplier Eight', 'Supplier8@supplier8.net', '0215551008', '88 Tech Park, Wellington'),
--('Supplier Nine', 'Supplier9@supplier9.co.nz', '0215551009', '19 Ocean Rd, Napier'),
--('Supplier Ten', 'Supplier10@supplier10.org', '0215551010', '77 South St, Invercargill');

--INSERT INTO Supplier (SupplierName, Email, PhoneNumber, Address)
--VALUES
--('Supplier One', 'Supplier1@supplier1.co.nz', '0215551001', '12 Industry Lane, Auckland'),
--('Supplier Two', 'Supplier2@supplier2.com', '0215551002', '45 Health St, Wellington'),
--('Supplier Three', 'Supplier3@supplier3.net', '0215551003', '78 Smile Ave, Christchurch'),
--('Supplier Four', 'Supplier4@supplier4.co.nz', '0215551004', '34 Care Rd, Hamilton'),
--('Supplier Five', 'Supplier5@supplier5.org', '0215551005', '56 Supply Dr, Tauranga'),
--('Supplier Six', 'Supplier6@supplier6.co.nz', '0215551006', '22 Market St, Dunedin'),
--('Supplier Seven', 'Supplier7@supplier7.com', '0215551007', '10 Harbour View Rd, Auckland'),
--('Supplier Eight', 'Supplier8@supplier8.net', '0215551008', '88 Tech Park, Wellington'),
--('Supplier Nine', 'Supplier9@supplier9.co.nz', '0215551009', '19 Ocean Rd, Napier'),
--('Supplier Ten', 'Supplier10@supplier10.org', '0215551010', '77 South St, Invercargill');

--INSERT INTO Item (SupplierID, ItemName, ItemDescription, Price, MinimumStock)
--VALUES 
--(3, 'Toothbrush', 'Soft bristle toothbrush', 3.50, 20),
--(7, 'Dental Floss', 'Mint flavored floss', 2.20, 30),
--(1, 'Mouthwash', 'Alcohol-free mouthwash', 5.99, 15),
--(9, 'Toothpaste', 'Whitening toothpaste', 4.75, 25),
--(5, 'Gloves', 'Latex examination gloves', 12.00, 50),
--(2, 'Face Mask', 'Disposable surgical masks', 8.50, 40),
--(10, 'Hand Sanitizer', '70% alcohol sanitizer', 6.25, 35),
--(6, 'Cotton Rolls', 'Dental cotton rolls pack', 9.80, 45),
--(4, 'Syringes', 'Sterile disposable syringes', 15.00, 60),
--(8, 'Disinfectant Wipes', 'Surface cleaning wipes', 7.30, 30);

---- Insert OrderItems
--INSERT INTO OrderItem (ItemID, OrderName, QuantityOrdered, OrderID) VALUES
--(3, 'Restock Toothbrushes', 100, 1),
--(6, 'Floss Bulk Order', 0, 2),
--(10, 'Mouthwash Shipment', 150, 3),
--(9, 'Toothpaste Refill', 120, 4),
--(4, 'Glove Supply Order', 300, 5),
--(3, 'Mask Restock', 250, 6),
--(2, 'Sanitizer Delivery', 180, 7),
--(1, 'Cotton Rolls Order', 220, 8),
--(8, 'Syringes Batch', 140, 9),
--(7, 'Wipes Replenishment', 160, 10);

--INSERT INTO [Order] (EstimatedTimeOfArrival, Status) VALUES
--('2026-04-01', 0),
--('2026-04-03', 0),
--('2026-04-02', 0),
--('2026-04-05', 0),
--('2026-04-04', 0),
--('2026-04-06', 0),
--('2026-04-07', 0),
--('2026-04-08', 0),
--('2026-04-09', 0),
--('2026-04-10', 0);

-- ================= SUPPLIER =================
INSERT INTO Supplier (SupplierName, Email, PhoneNumber, Address) VALUES
('Supplier One', 'Supplier1@supplier1.co.nz', '0215551001', '12 Industry Lane, Auckland'),
('Supplier Two', 'Supplier2@supplier2.com', '0215551002', '45 Health St, Wellington'),
('Supplier Three', 'Supplier3@supplier3.net', '78 Smile Ave, Christchurch'),
('Supplier Four', 'Supplier4@supplier4.co.nz', '0215551004', '34 Care Rd, Hamilton'),
('Supplier Five', 'Supplier5@supplier5.org', '0215551005', '56 Supply Dr, Tauranga'),
('Supplier Six', 'Supplier6@supplier6.co.nz', '0215551006', '22 Market St, Dunedin'),
('Supplier Seven', 'Supplier7@supplier7.com', '0215551007', '10 Harbour View Rd, Auckland'),
('Supplier Eight', 'Supplier8@supplier8.net', '0215551008', '88 Tech Park, Wellington'),
('Supplier Nine', 'Supplier9@supplier9.co.nz', '0215551009', '19 Ocean Rd, Napier'),
('Supplier Ten', 'Supplier10@supplier10.org', '0215551010', '77 South St, Invercargill');

-- ================= LOCATION =================
INSERT INTO Location (LocationName, LocationAddress) VALUES
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

-- ================= ITEM =================
INSERT INTO Item (SupplierID, ItemName, ItemDescription, Price, MinimumStock) VALUES
(3, 'Toothbrush', 'Soft bristle toothbrush', 3, 20),
(7, 'Dental Floss', 'Mint flavored floss', 2, 30),
(1, 'Mouthwash', 'Alcohol-free mouthwash', 5, 15),
(9, 'Toothpaste', 'Whitening toothpaste', 4, 25),
(5, 'Gloves', 'Latex examination gloves', 12, 50),
(2, 'Face Mask', 'Disposable surgical masks', 8, 40),
(10, 'Hand Sanitizer', '70% alcohol sanitizer', 6, 35),
(6, 'Cotton Rolls', 'Dental cotton rolls pack', 9, 45),
(4, 'Syringes', 'Sterile disposable syringes', 15, 60),
(8, 'Disinfectant Wipes', 'Surface cleaning wipes', 7, 30);

-- ================= ORDER =================
INSERT INTO [Order] (EstimatedTimeOfArrival, Status, OrderName) VALUES
('2026-04-01', 0, 'Restock Toothbrushes'),
('2026-04-03', 0, 'Floss Bulk Order'),
('2026-04-02', 0, 'Mouthwash Shipment'),
('2026-04-05', 0, 'Toothpaste Refill'),
('2026-04-04', 0, 'Glove Supply Order'),
('2026-04-06', 0, 'Mask Restock'),
('2026-04-07', 0, 'Sanitizer Delivery'),
('2026-04-08', 0, 'Cotton Rolls Order'),
('2026-04-09', 0, 'Syringes Batch'),
('2026-04-10', 0, 'Wipes Replenishment');

-- ================= ITEM LOCATION =================
INSERT INTO ItemLocation (ItemID, SupplierID, LocationID, Quantity) VALUES
(3, 3, 2, 50),
(2, 7, 5, 30),
(1, 1, 4, 20),
(4, 9, 6, 15),
(6, 2, 3, 60),
(10, 8, 1, 25),
(7, 10, 7, 40),
(9, 4, 8, 35),
(8, 6, 9, 45),
(5, 5, 10, 55);

-- ================= ORDER ITEM =================
INSERT INTO OrderItem (ItemID, QuantityOrdered, OrderID) VALUES
(3, 100, 1),
(6, 100, 2),
(10, 150, 3),
(9, 120, 4),
(4, 300, 5),
(3, 250, 6),
(2, 180, 7),
(1, 220, 8),
(8, 140, 9),
(7, 160, 10);