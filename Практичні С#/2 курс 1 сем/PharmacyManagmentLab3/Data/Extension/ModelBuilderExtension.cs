using System;
using System.Collections.Generic;
using System.Text;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Extension
{
    public static class ModelBuilderExtension
    {
        public static void SeedPharmacyData(this ModelBuilder modelBuilder)
        {
            modelBuilder.SeedActiveIngredient();
            modelBuilder.SeedBrand();
            modelBuilder.SeedMedicine();
            modelBuilder.SeedSupplier();
            modelBuilder.SeedPurchaseOrder();
            modelBuilder.SeedPurchaseOrderItem();
            modelBuilder.SeedRefrigerator();
            modelBuilder.SeedRefrigeratorLog();
            modelBuilder.SeedBatch();
            modelBuilder.SeedShelf();
            modelBuilder.SeedShelfItem();
            modelBuilder.SeedRecipe();
            modelBuilder.SeedReturnPolicy();
            modelBuilder.SeedSale();
        }



        public static void SeedActiveIngredient(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Active_Ingredient>().HasData(
                new Active_Ingredient { Id = 1, Name = "Paracetamol" },
                new Active_Ingredient { Id = 2, Name = "Ibuprofen" },
                new Active_Ingredient { Id = 3, Name = "Amoxicillin" },
                new Active_Ingredient { Id = 4, Name = "Cetirizine" },
                new Active_Ingredient { Id = 5, Name = "Loratadine" },
                new Active_Ingredient { Id = 6, Name = "Azithromycin" },
                new Active_Ingredient { Id = 7, Name = "Metformin" },
                new Active_Ingredient { Id = 8, Name = "Omeprazole" },
                new Active_Ingredient { Id = 9, Name = "Aspirin" },
                new Active_Ingredient { Id = 10, Name = "Dextromethorphan" }
            );
        }

        private static void SeedBrand(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().HasData(
                new Brand { Id = 1, Name = "Bayer" },
                new Brand { Id = 2, Name = "Pfizer" },
                new Brand { Id = 3, Name = "Novartis" },
                new Brand { Id = 4, Name = "Johnson & Johnson" },
                new Brand { Id = 5, Name = "GSK" },
                new Brand { Id = 6, Name = "Sanofi" },
                new Brand { Id = 7, Name = "Roche" },
                new Brand { Id = 8, Name = "Merck" },
                new Brand { Id = 9, Name = "AstraZeneca" },
                new Brand { Id = 10, Name = "Teva" }
            );
        }

        private static void SeedMedicine(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medicine>().HasData(
                new Medicine { Id = 1, Name = "Panadol", Storage_Conditions = "Room temperature", Is_Child_form = false, Seasonal_Status = "Year-round", Dosage = 500, Release_Form = "Tablets", Prescription_Required = false, BrandId = 1, Active_IngredientId = 1 },
                new Medicine { Id = 2, Name = "Nurofen", Storage_Conditions = "Room temperature", Is_Child_form = false, Seasonal_Status = "Year-round", Dosage = 400, Release_Form = "Tablets", Prescription_Required = false, BrandId = 2, Active_IngredientId = 2 },
                new Medicine { Id = 3, Name = "Amoxil", Storage_Conditions = "Room temperature", Is_Child_form = false, Seasonal_Status = "Year-round", Dosage = 250, Release_Form = "Capsules", Prescription_Required = true, BrandId = 3, Active_IngredientId = 3 },
                new Medicine { Id = 4, Name = "Zyrtec", Storage_Conditions = "Room temperature", Is_Child_form = false, Seasonal_Status = "Spring/Fall", Dosage = 10, Release_Form = "Tablets", Prescription_Required = false, BrandId = 4, Active_IngredientId = 4 },
                new Medicine { Id = 5, Name = "Claritin", Storage_Conditions = "Room temperature", Is_Child_form = false, Seasonal_Status = "Spring/Fall", Dosage = 10, Release_Form = "Tablets", Prescription_Required = false, BrandId = 5, Active_IngredientId = 5 },
                new Medicine { Id = 6, Name = "Zithromax", Storage_Conditions = "Room temperature", Is_Child_form = false, Seasonal_Status = "Year-round", Dosage = 500, Release_Form = "Tablets", Prescription_Required = true, BrandId = 6, Active_IngredientId = 6 },
                new Medicine { Id = 7, Name = "Glucophage", Storage_Conditions = "Room temperature", Is_Child_form = false, Seasonal_Status = "Year-round", Dosage = 850, Release_Form = "Tablets", Prescription_Required = true, BrandId = 7, Active_IngredientId = 7 },
                new Medicine { Id = 8, Name = "Prilosec", Storage_Conditions = "Room temperature", Is_Child_form = false, Seasonal_Status = "Year-round", Dosage = 20, Release_Form = "Capsules", Prescription_Required = false, BrandId = 8, Active_IngredientId = 8 },
                new Medicine { Id = 9, Name = "Aspirin Bayer", Storage_Conditions = "Room temperature", Is_Child_form = false, Seasonal_Status = "Year-round", Dosage = 100, Release_Form = "Tablets", Prescription_Required = false, BrandId = 1, Active_IngredientId = 9 },
                new Medicine { Id = 10, Name = "Robitussin", Storage_Conditions = "Room temperature", Is_Child_form = true, Seasonal_Status = "Winter", Dosage = 15, Release_Form = "Syrup", Prescription_Required = false, BrandId = 9, Active_IngredientId = 10 }
            );
        }

        private static void SeedSupplier(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { SupplierId = 1, SupplierName = "MedSupply Co.", Phone = "+380501234567" },
                new Supplier { SupplierId = 2, SupplierName = "PharmaDistribution Ltd.", Phone = "+380502345678" },
                new Supplier { SupplierId = 3, SupplierName = "HealthCare Supplies", Phone = "+380503456789" },
                new Supplier { SupplierId = 4, SupplierName = "Global Pharma Inc.", Phone = "+380504567890" },
                new Supplier { SupplierId = 5, SupplierName = "MediWorld Trading", Phone = "+380505678901" },
                new Supplier { SupplierId = 6, SupplierName = "PharmaTech Solutions", Phone = "+380506789012" },
                new Supplier { SupplierId = 7, SupplierName = "BioMed Distributors", Phone = "+380507890123" },
                new Supplier { SupplierId = 8, SupplierName = "EuroPharma Group", Phone = "+380508901234" },
                new Supplier { SupplierId = 9, SupplierName = "MedExpress Logistics", Phone = "+380509012345" },
                new Supplier { SupplierId = 10, SupplierName = "Pharmaceutical Wholesale", Phone = "+380500123456" }
            );
        }

        private static void SeedPurchaseOrder(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Purchase_Order>().HasData(
                new Purchase_Order { Purchase_Order_Id = 1, Order_Date = new DateTime(2024, 11, 1), Status = "Completed", SupplierId = 1 },
                new Purchase_Order { Purchase_Order_Id = 2, Order_Date = new DateTime(2024, 11, 5), Status = "Completed", SupplierId = 2 },
                new Purchase_Order { Purchase_Order_Id = 3, Order_Date = new DateTime(2024, 11, 10), Status = "Pending", SupplierId = 3 },
                new Purchase_Order { Purchase_Order_Id = 4, Order_Date = new DateTime(2024, 11, 12), Status = "Completed", SupplierId = 4 },
                new Purchase_Order { Purchase_Order_Id = 5, Order_Date = new DateTime(2024, 11, 15), Status = "In Transit", SupplierId = 5 },
                new Purchase_Order { Purchase_Order_Id = 6, Order_Date = new DateTime(2024, 11, 18), Status = "Completed", SupplierId = 6 },
                new Purchase_Order { Purchase_Order_Id = 7, Order_Date = new DateTime(2024, 11, 20), Status = "Pending", SupplierId = 7 },
                new Purchase_Order { Purchase_Order_Id = 8, Order_Date = new DateTime(2024, 11, 22), Status = "Completed", SupplierId = 8 },
                new Purchase_Order { Purchase_Order_Id = 9, Order_Date = new DateTime(2024, 11, 25), Status = "In Transit", SupplierId = 9 },
                new Purchase_Order { Purchase_Order_Id = 10, Order_Date = new DateTime(2024, 11, 28), Status = "Pending", SupplierId = 10 }
            );
        }

        private static void SeedPurchaseOrderItem(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Purchase_Order_Item>().HasData(
                new Purchase_Order_Item { Purchase_Order_Item_Id = 1, Quantity = 100, Purchase_orderId = 1, MedicineId = 1 },
                new Purchase_Order_Item { Purchase_Order_Item_Id = 2, Quantity = 150, Purchase_orderId = 1, MedicineId = 2 },
                new Purchase_Order_Item { Purchase_Order_Item_Id = 3, Quantity = 80, Purchase_orderId = 2, MedicineId = 3 },
                new Purchase_Order_Item { Purchase_Order_Item_Id = 4, Quantity = 200, Purchase_orderId = 2, MedicineId = 4 },
                new Purchase_Order_Item { Purchase_Order_Item_Id = 5, Quantity = 120, Purchase_orderId = 3, MedicineId = 5 },
                new Purchase_Order_Item { Purchase_Order_Item_Id = 6, Quantity = 90, Purchase_orderId = 4, MedicineId = 6 },
                new Purchase_Order_Item { Purchase_Order_Item_Id = 7, Quantity = 110, Purchase_orderId = 5, MedicineId = 7 },
                new Purchase_Order_Item { Purchase_Order_Item_Id = 8, Quantity = 180, Purchase_orderId = 6, MedicineId = 8 },
                new Purchase_Order_Item { Purchase_Order_Item_Id = 9, Quantity = 140, Purchase_orderId = 7, MedicineId = 9 },
                new Purchase_Order_Item { Purchase_Order_Item_Id = 10, Quantity = 75, Purchase_orderId = 8, MedicineId = 10 }
            );
        }

        private static void SeedRefrigerator(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Refrigerator>().HasData(
                new Refrigerator { Refrigerator_Id = 1, Refrigerator_Name = "Main Storage Fridge A" },
                new Refrigerator { Refrigerator_Id = 2, Refrigerator_Name = "Main Storage Fridge B" },
                new Refrigerator { Refrigerator_Id = 3, Refrigerator_Name = "Vaccine Storage Unit" },
                new Refrigerator { Refrigerator_Id = 4, Refrigerator_Name = "Insulin Storage Fridge" },
                new Refrigerator { Refrigerator_Id = 5, Refrigerator_Name = "Backup Cooling Unit" }
            );
        }

        private static void SeedRefrigeratorLog(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Refrigerator_Log>().HasData(
                new Refrigerator_Log { Log_Id = 1, Min_Temp = 2.0, Max_Temp = 8.0, Current_Temp = 5.2, Log_Date = new DateTime(2024, 11, 28, 8, 0, 0), RefrigeratorId = 1 },
                new Refrigerator_Log { Log_Id = 2, Min_Temp = 2.0, Max_Temp = 8.0, Current_Temp = 4.8, Log_Date = new DateTime(2024, 11, 28, 12, 0, 0), RefrigeratorId = 1 },
                new Refrigerator_Log { Log_Id = 3, Min_Temp = 2.0, Max_Temp = 8.0, Current_Temp = 6.1, Log_Date = new DateTime(2024, 11, 28, 8, 0, 0), RefrigeratorId = 2 },
                new Refrigerator_Log { Log_Id = 4, Min_Temp = 2.0, Max_Temp = 8.0, Current_Temp = 5.5, Log_Date = new DateTime(2024, 11, 28, 12, 0, 0), RefrigeratorId = 2 },
                new Refrigerator_Log { Log_Id = 5, Min_Temp = 2.0, Max_Temp = 8.0, Current_Temp = 3.9, Log_Date = new DateTime(2024, 11, 28, 8, 0, 0), RefrigeratorId = 3 },
                new Refrigerator_Log { Log_Id = 6, Min_Temp = 2.0, Max_Temp = 8.0, Current_Temp = 4.2, Log_Date = new DateTime(2024, 11, 28, 12, 0, 0), RefrigeratorId = 3 },
                new Refrigerator_Log { Log_Id = 7, Min_Temp = 2.0, Max_Temp = 8.0, Current_Temp = 5.8, Log_Date = new DateTime(2024, 11, 28, 8, 0, 0), RefrigeratorId = 4 },
                new Refrigerator_Log { Log_Id = 8, Min_Temp = 2.0, Max_Temp = 8.0, Current_Temp = 6.3, Log_Date = new DateTime(2024, 11, 28, 12, 0, 0), RefrigeratorId = 4 },
                new Refrigerator_Log { Log_Id = 9, Min_Temp = 2.0, Max_Temp = 8.0, Current_Temp = 4.5, Log_Date = new DateTime(2024, 11, 28, 8, 0, 0), RefrigeratorId = 5 },
                new Refrigerator_Log { Log_Id = 10, Min_Temp = 2.0, Max_Temp = 8.0, Current_Temp = 5.0, Log_Date = new DateTime(2024, 11, 28, 12, 0, 0), RefrigeratorId = 5 }
            );
        }

        private static void SeedBatch(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Batch>().HasData(
                new Batch { Batch_Id = 1, Batch_Num = "BTH-2024-001", Arrival_Date = new DateTime(2024, 11, 5), Expiri_Date = new DateTime(2026, 11, 5), Stock_Quantity = 100, Initial_Quantity = 100, Unit_Price = 1275.00m, MedicineId = 1, Purchase_OrderId = 1, RefrigeratorId = null },
                new Batch { Batch_Id = 2, Batch_Num = "BTH-2024-002", Arrival_Date = new DateTime(2024, 11, 5), Expiri_Date = new DateTime(2026, 11, 5), Stock_Quantity = 150, Initial_Quantity = 150, Unit_Price = 2700.00m, MedicineId = 2, Purchase_OrderId = 1, RefrigeratorId = null },
                new Batch { Batch_Id = 3, Batch_Num = "BTH-2024-003", Arrival_Date = new DateTime(2024, 11, 8), Expiri_Date = new DateTime(2026, 5, 8), Stock_Quantity = 80, Initial_Quantity = 80, Unit_Price = 1200.00m, MedicineId = 3, Purchase_OrderId = 2, RefrigeratorId = null },
                new Batch { Batch_Id = 4, Batch_Num = "BTH-2024-004", Arrival_Date = new DateTime(2024, 11, 8), Expiri_Date = new DateTime(2027, 11, 8), Stock_Quantity = 200, Initial_Quantity = 200, Unit_Price = 3000.00m, MedicineId = 4, Purchase_OrderId = 2, RefrigeratorId = null },
                new Batch { Batch_Id = 5, Batch_Num = "BTH-2024-005", Arrival_Date = new DateTime(2024, 11, 15), Expiri_Date = new DateTime(2027, 11, 15), Stock_Quantity = 120, Initial_Quantity = 120, Unit_Price = 1800.00m, MedicineId = 5, Purchase_OrderId = 4, RefrigeratorId = null },
                new Batch { Batch_Id = 6, Batch_Num = "BTH-2024-006", Arrival_Date = new DateTime(2024, 11, 20), Expiri_Date = new DateTime(2026, 11, 20), Stock_Quantity = 90, Initial_Quantity = 90, Unit_Price = 4950.00m, MedicineId = 6, Purchase_OrderId = 6, RefrigeratorId = 1 },
                new Batch { Batch_Id = 7, Batch_Num = "BTH-2024-007", Arrival_Date = new DateTime(2024, 11, 22), Expiri_Date = new DateTime(2027, 11, 22), Stock_Quantity = 180, Initial_Quantity = 180, Unit_Price = 5130.00m, MedicineId = 8, Purchase_OrderId = 8, RefrigeratorId = null },
                new Batch { Batch_Id = 8, Batch_Num = "BTH-2024-008", Arrival_Date = new DateTime(2024, 11, 5), Expiri_Date = new DateTime(2027, 5, 5), Stock_Quantity = 140, Initial_Quantity = 140, Unit_Price = 1680.00m, MedicineId = 9, Purchase_OrderId = 1, RefrigeratorId = null },
                new Batch { Batch_Id = 9, Batch_Num = "BTH-2024-009", Arrival_Date = new DateTime(2024, 11, 22), Expiri_Date = new DateTime(2026, 5, 22), Stock_Quantity = 75, Initial_Quantity = 75, Unit_Price = 1125.00m, MedicineId = 10, Purchase_OrderId = 8, RefrigeratorId = 2 },
                new Batch { Batch_Id = 10, Batch_Num = "BTH-2024-010", Arrival_Date = new DateTime(2024, 11, 8), Expiri_Date = new DateTime(2027, 2, 8), Stock_Quantity = 110, Initial_Quantity = 110, Unit_Price = 2750.00m, MedicineId = 7, Purchase_OrderId = 2, RefrigeratorId = null }
            );
        }

        private static void SeedShelf(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shelf>().HasData(
                new Shelf { ShelfId = 1, Zone = "Zone A", ShelfNumber = 1, RowNumber = 1 },
                new Shelf { ShelfId = 2, Zone = "Zone A", ShelfNumber = 1, RowNumber = 2 },
                new Shelf { ShelfId = 3, Zone = "Zone A", ShelfNumber = 2, RowNumber = 1 },
                new Shelf { ShelfId = 4, Zone = "Zone B", ShelfNumber = 1, RowNumber = 1 },
                new Shelf { ShelfId = 5, Zone = "Zone B", ShelfNumber = 1, RowNumber = 2 },
                new Shelf { ShelfId = 6, Zone = "Zone B", ShelfNumber = 2, RowNumber = 1 },
                new Shelf { ShelfId = 7, Zone = "Zone C", ShelfNumber = 1, RowNumber = 1 },
                new Shelf { ShelfId = 8, Zone = "Zone C", ShelfNumber = 1, RowNumber = 2 },
                new Shelf { ShelfId = 9, Zone = "Zone C", ShelfNumber = 2, RowNumber = 1 },
                new Shelf { ShelfId = 10, Zone = "Zone D", ShelfNumber = 1, RowNumber = 1 }
            );
        }

        private static void SeedShelfItem(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shelf_Item>().HasData(
                new Shelf_Item { Shelf_Item_Id = 1, Face_Required = 10, Face_Current = 8, Location_Hint = "Left side", Last_Updated = new DateTime(2024, 11, 13, 8, 0, 0), ShelfId = 1, MedicineId = 1 },
                new Shelf_Item { Shelf_Item_Id = 2, Face_Required = 15, Face_Current = 12, Location_Hint = "Center", Last_Updated = new DateTime(2024, 11, 28, 9, 0, 0), ShelfId = 1, MedicineId = 2 },
                new Shelf_Item { Shelf_Item_Id = 3, Face_Required = 8, Face_Current = 6, Location_Hint = "Right side", Last_Updated = new DateTime(2024, 11, 7, 8, 0, 0), ShelfId = 2, MedicineId = 3 },
                new Shelf_Item { Shelf_Item_Id = 4, Face_Required = 20, Face_Current = 18, Location_Hint = "Top shelf", Last_Updated = new DateTime(2024, 11, 28, 8, 0, 0), ShelfId = 3, MedicineId = 4 },
                new Shelf_Item { Shelf_Item_Id = 5, Face_Required = 12, Face_Current = 10, Location_Hint = "Bottom", Last_Updated = new DateTime(2024, 11, 28, 8, 0, 0), ShelfId = 4, MedicineId = 5 },
                new Shelf_Item { Shelf_Item_Id = 6, Face_Required = 9, Face_Current = 7, Location_Hint = "Left corner", Last_Updated = new DateTime(2024, 11, 28, 8, 0, 0), ShelfId = 5, MedicineId = 6 },
                new Shelf_Item { Shelf_Item_Id = 7, Face_Required = 18, Face_Current = 16, Location_Hint = "Middle row", Last_Updated = new DateTime(2024, 11, 28, 8, 0, 0), ShelfId = 6, MedicineId = 7 },
                new Shelf_Item { Shelf_Item_Id = 8, Face_Required = 14, Face_Current = 11, Location_Hint = "Right corner", Last_Updated = new DateTime(2024, 11, 28, 8, 0, 0), ShelfId = 7, MedicineId = 8 },
                new Shelf_Item { Shelf_Item_Id = 9, Face_Required = 7, Face_Current = 5, Location_Hint = "Front facing", Last_Updated = new DateTime(2024, 11, 28, 8, 0, 0), ShelfId = 8, MedicineId = 9 },
                new Shelf_Item { Shelf_Item_Id = 10, Face_Required = 11, Face_Current = 9, Location_Hint = "Back row", Last_Updated = new DateTime(2024, 12, 28, 8, 0, 0), ShelfId = 9, MedicineId = 10 }
            );
        }

        private static void SeedRecipe(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().HasData(
                new Recipe { Recipe_Id = 1, Doctor_Name = "Dr. Ivan Petrov", Doctor_Phone = "+380671234567", Can_use_alternative = true, MedicineId = 3 },
                new Recipe { Recipe_Id = 2, Doctor_Name = "Dr. Olena Kovalenko", Doctor_Phone = "+380672345678", Can_use_alternative = false, MedicineId = 6 },
                new Recipe { Recipe_Id = 3, Doctor_Name = "Dr. Andriy Shevchenko", Doctor_Phone = "+380673456789", Can_use_alternative = true, MedicineId = 7 },
                new Recipe { Recipe_Id = 4, Doctor_Name = "Dr. Maria Bondarenko", Doctor_Phone = "+380674567890", Can_use_alternative = true, MedicineId = 3 },
                new Recipe { Recipe_Id = 5, Doctor_Name = "Dr. Ivan Petrov", Doctor_Phone = "+380671234567", Can_use_alternative = false, MedicineId = 6 },
                new Recipe { Recipe_Id = 6, Doctor_Name = "Dr. Serhiy Lysenko", Doctor_Phone = "+380675678901", Can_use_alternative = true, MedicineId = 7 },
                new Recipe { Recipe_Id = 7, Doctor_Name = "Dr. Olena Kovalenko", Doctor_Phone = "+380672345678", Can_use_alternative = false, MedicineId = 3 },
                new Recipe { Recipe_Id = 8, Doctor_Name = "Dr. Natalia Tkachenko", Doctor_Phone = "+380676789012", Can_use_alternative = true, MedicineId = 6 },
                new Recipe { Recipe_Id = 9, Doctor_Name = "Dr. Andriy Shevchenko", Doctor_Phone = "+380673456789", Can_use_alternative = true, MedicineId = 7 },
                new Recipe { Recipe_Id = 10, Doctor_Name = "Dr. Maria Bondarenko", Doctor_Phone = "+380674567890", Can_use_alternative = false, MedicineId = 3 }
            );
        }

        private static void SeedSale(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sale>().HasData(
                new Sale { Sale_Id = 1, Date_Of_Sale = new DateTime(2024, 11, 20), Quantity = 2, Customer_Name = "Oleksandr Ivanov", Price = 25.50m, MedicineId = 1, BatchId = 1, Return_Policy_Id = 1 },
                new Sale { Sale_Id = 2, Date_Of_Sale = new DateTime(2024, 11, 21), Quantity = 1, Customer_Name = "Yulia Moroz", Price = 18.00m, MedicineId = 2, BatchId = 2, Return_Policy_Id = 2 },
                new Sale { Sale_Id = 3, Date_Of_Sale = new DateTime(2024, 11, 22), Quantity = 3, Customer_Name = "Viktor Kravchenko", Price = 45.00m, MedicineId = 4, BatchId = 4, Return_Policy_Id = 3 },
                new Sale { Sale_Id = 4, Date_Of_Sale = new DateTime(2024, 11, 23), Quantity = 2, Customer_Name = "Iryna Savchenko", Price = 32.00m, MedicineId = 5, BatchId = 5, Return_Policy_Id = 4 },
                new Sale { Sale_Id = 5, Date_Of_Sale = new DateTime(2024, 11, 24), Quantity = 1, Customer_Name = "Dmytro Polishchuk", Price = 55.00m, MedicineId = 6, BatchId = 6, Return_Policy_Id = 5 },
                new Sale { Sale_Id = 6, Date_Of_Sale = new DateTime(2024, 11, 25), Quantity = 4, Customer_Name = "Tetiana Melnyk", Price = 68.00m, MedicineId = 7, BatchId = 10, Return_Policy_Id = null },
                new Sale { Sale_Id = 7, Date_Of_Sale = new DateTime(2024, 11, 26), Quantity = 2, Customer_Name = "Mykola Boyko", Price = 28.50m, MedicineId = 8, BatchId = 7, Return_Policy_Id = null },
                new Sale { Sale_Id = 8, Date_Of_Sale = new DateTime(2024, 11, 27), Quantity = 1, Customer_Name = "Oksana Koval", Price = 12.00m, MedicineId = 9, BatchId = 8, Return_Policy_Id = null },
                new Sale { Sale_Id = 9, Date_Of_Sale = new DateTime(2024, 11, 27), Quantity = 3, Customer_Name = "Roman Sokolenko", Price = 42.00m, MedicineId = 1, BatchId = 1, Return_Policy_Id = null },
                new Sale { Sale_Id = 10, Date_Of_Sale = new DateTime(2024, 11, 28), Quantity = 2, Customer_Name = "Lesia Hrytsenko", Price = 36.00m, MedicineId = 2, BatchId = 2, Return_Policy_Id = null }
            );
        }

        private static void SeedReturnPolicy(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Return_Policy>().HasData(
                new Return_Policy { Return_Policy_Id = 1, Reason = "Wrong medicine purchased", Signature1 = "O. Ivanov", Signature2 = "Pharmacist A", Pasport_Data = "AA1234567", SaleId = 1 },
                new Return_Policy { Return_Policy_Id = 2, Reason = "Allergic reaction", Signature1 = "Y. Moroz", Signature2 = "Pharmacist B", Pasport_Data = "BB7654321", SaleId = 2 },
                new Return_Policy { Return_Policy_Id = 3, Reason = "Expired product", Signature1 = "V. Kravchenko", Signature2 = "Pharmacist C", Pasport_Data = "CC1122334", SaleId = 3 },
                new Return_Policy { Return_Policy_Id = 4, Reason = "Doctor changed prescription", Signature1 = "I. Savchenko", Signature2 = "Pharmacist A", Pasport_Data = "DD5566778", SaleId = 4 },
                new Return_Policy { Return_Policy_Id = 5, Reason = "Duplicate purchase", Signature1 = "D. Polishchuk", Signature2 = "Pharmacist D", Pasport_Data = "EE9988776", SaleId = 5 }
            );
        }
    }
}
