using System;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public static class ModelBuilderExtension
    {
        public static void SeedFinalProjectData(this ModelBuilder modelBuilder)
        {
            SeedWarehouses(modelBuilder);
            SeedStorageZones(modelBuilder);
            SeedStorageBins(modelBuilder);
            SeedTariffPlans(modelBuilder);
            SeedClients(modelBuilder);
            SeedProducts(modelBuilder);
            SeedInboundOrders(modelBuilder);
            SeedOutboundOrders(modelBuilder);
            SeedInventoryItems(modelBuilder);
            SeedStockMovements(modelBuilder);
            SeedBillingRecords(modelBuilder);
        }

        private static void SeedWarehouses(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Warehouse>().HasData(
                new Warehouse { Id = 1, Name = "Kyiv Central Hub", Address = "Kyiv, Industrialna 1" },
                new Warehouse { Id = 2, Name = "Lviv West Terminal", Address = "Lviv, Horodotska 220" },
                new Warehouse { Id = 3, Name = "Odesa Port Logistics", Address = "Odesa, Prymorska 5" },
                new Warehouse { Id = 4, Name = "Kharkiv East Depot", Address = "Kharkiv, Gagarina 10" },
                new Warehouse { Id = 5, Name = "Dnipro Cargo Center", Address = "Dnipro, Slobozhansky 15" },
                new Warehouse { Id = 6, Name = "Kyiv Cold Storage", Address = "Kyiv, Kilceva 4" },
                new Warehouse { Id = 7, Name = "Poltava Distribution", Address = "Poltava, Kyivske Hwy 3" },
                new Warehouse { Id = 8, Name = "Vinnytsia Transit", Address = "Vinnytsia, Khmelnytske Hwy 7" },
                new Warehouse { Id = 9, Name = "Zaporizhzhia Industrial", Address = "Zaporizhzhia, Metalurgiv 2" },
                new Warehouse { Id = 10, Name = "Uzhhorod Border Hub", Address = "Uzhhorod, Sobranetska 100" }
            );
        }

        private static void SeedStorageZones(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StorageZone>().HasData(
                new StorageZone { Id = 1, Name = "Zone A (General)", CostMultiplier = 1.0m, WarehouseId = 1 },
                new StorageZone { Id = 2, Name = "Zone B (Secure)", CostMultiplier = 1.5m, WarehouseId = 1 },
                new StorageZone { Id = 3, Name = "Zone C (Cold)", CostMultiplier = 2.0m, WarehouseId = 2 },
                new StorageZone { Id = 4, Name = "Zone D (Bulk)", CostMultiplier = 0.8m, WarehouseId = 2 },
                new StorageZone { Id = 5, Name = "Zone E (Hazardous)", CostMultiplier = 3.0m, WarehouseId = 3 },
                new StorageZone { Id = 6, Name = "Zone F (Electronics)", CostMultiplier = 1.2m, WarehouseId = 4 },
                new StorageZone { Id = 7, Name = "Zone G (Food)", CostMultiplier = 1.1m, WarehouseId = 5 },
                new StorageZone { Id = 8, Name = "Zone H (Freezer)", CostMultiplier = 2.5m, WarehouseId = 6 },
                new StorageZone { Id = 9, Name = "Zone I (Textile)", CostMultiplier = 1.0m, WarehouseId = 7 },
                new StorageZone { Id = 10, Name = "Zone J (Returns)", CostMultiplier = 0.5m, WarehouseId = 1 }
            );
        }

        private static void SeedStorageBins(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StorageBin>().HasData(
                new StorageBin { Id = 1, Code = "A-01-01", MaxVolume = 2.0m, MaxWeight = 500m, StorageZoneId = 1 },
                new StorageBin { Id = 2, Code = "A-01-02", MaxVolume = 2.0m, MaxWeight = 500m, StorageZoneId = 1 },
                new StorageBin { Id = 3, Code = "B-05-10", MaxVolume = 1.0m, MaxWeight = 200m, StorageZoneId = 2 },
                new StorageBin { Id = 4, Code = "C-COLD-01", MaxVolume = 1.5m, MaxWeight = 300m, StorageZoneId = 3 },
                new StorageBin { Id = 5, Code = "D-BULK-99", MaxVolume = 10.0m, MaxWeight = 5000m, StorageZoneId = 4 },
                new StorageBin { Id = 6, Code = "E-HAZ-01", MaxVolume = 0.5m, MaxWeight = 100m, StorageZoneId = 5 },
                new StorageBin { Id = 7, Code = "F-ELEC-05", MaxVolume = 1.0m, MaxWeight = 150m, StorageZoneId = 6 },
                new StorageBin { Id = 8, Code = "G-FOOD-22", MaxVolume = 2.0m, MaxWeight = 400m, StorageZoneId = 7 },
                new StorageBin { Id = 9, Code = "H-FRZ-01", MaxVolume = 1.5m, MaxWeight = 300m, StorageZoneId = 8 },
                new StorageBin { Id = 10, Code = "I-TEX-07", MaxVolume = 3.0m, MaxWeight = 200m, StorageZoneId = 9 }
            );
        }

        private static void SeedTariffPlans(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TariffPlan>().HasData(
                new TariffPlan { Id = 1, Name = "Standard Retail", DailyStorageCostPerCubicMeter = 10.0m, HandlingFeePerUnit = 5.0m },
                new TariffPlan { Id = 2, Name = "Premium Secure", DailyStorageCostPerCubicMeter = 20.0m, HandlingFeePerUnit = 10.0m },
                new TariffPlan { Id = 3, Name = "Cold Chain", DailyStorageCostPerCubicMeter = 30.0m, HandlingFeePerUnit = 15.0m },
                new TariffPlan { Id = 4, Name = "E-commerce Lite", DailyStorageCostPerCubicMeter = 12.0m, HandlingFeePerUnit = 3.0m },
                new TariffPlan { Id = 5, Name = "Wholesale Bulk", DailyStorageCostPerCubicMeter = 8.0m, HandlingFeePerUnit = 2.0m },
                new TariffPlan { Id = 6, Name = "Hazardous Material", DailyStorageCostPerCubicMeter = 50.0m, HandlingFeePerUnit = 25.0m },
                new TariffPlan { Id = 7, Name = "Long Term Storage", DailyStorageCostPerCubicMeter = 5.0m, HandlingFeePerUnit = 10.0m },
                new TariffPlan { Id = 8, Name = "Express Handling", DailyStorageCostPerCubicMeter = 15.0m, HandlingFeePerUnit = 20.0m },
                new TariffPlan { Id = 9, Name = "Fragile Goods", DailyStorageCostPerCubicMeter = 18.0m, HandlingFeePerUnit = 12.0m },
                new TariffPlan { Id = 10, Name = "VIP Client", DailyStorageCostPerCubicMeter = 25.0m, HandlingFeePerUnit = 0.0m }
            );
        }

        private static void SeedClients(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
                new Client { Id = 1, CompanyName = "TechNova", Phone = "+380501112233", Email = "contact@technova.com", TariffPlanId = 1 },
                new Client { Id = 2, CompanyName = "GreenGrocer", Phone = "+380672223344", Email = "supply@greengrocer.ua", TariffPlanId = 3 },
                new Client { Id = 3, CompanyName = "BuildMaster", Phone = "+380633334455", Email = "info@buildmaster.com", TariffPlanId = 5 },
                new Client { Id = 4, CompanyName = "Fashionista", Phone = "+380994445566", Email = "logistics@fashionista.com", TariffPlanId = 1 },
                new Client { Id = 5, CompanyName = "MediCare Pharm", Phone = "+380975556677", Email = "warehouse@medicare.com", TariffPlanId = 2 },
                new Client { Id = 6, CompanyName = "AutoParts UA", Phone = "+380506667788", Email = "sales@autoparts.ua", TariffPlanId = 1 },
                new Client { Id = 7, CompanyName = "ChemSolutions", Phone = "+380637778899", Email = "safety@chemsolutions.com", TariffPlanId = 6 },
                new Client { Id = 8, CompanyName = "ToyWonderland", Phone = "+380958889900", Email = "kids@toywonderland.com", TariffPlanId = 4 },
                new Client { Id = 9, CompanyName = "FrozenDelights", Phone = "+380679990011", Email = "ice@frozendelights.com", TariffPlanId = 3 },
                new Client { Id = 10, CompanyName = "LuxuryImports", Phone = "+380501234567", Email = "vip@luxuryimports.com", TariffPlanId = 10 }
            );
        }

        private static void SeedProducts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop Pro 15", SKU = "TECH-001", Description = "High-end laptop", Length = 0.4m, Width = 0.3m, Height = 0.05m, Weight = 2.0m, ClientId = 1 },
                new Product { Id = 2, Name = "Organic Apples", SKU = "FOOD-055", Description = "Fresh fruits", Length = 0.5m, Width = 0.4m, Height = 0.3m, Weight = 10.0m, ClientId = 2 },
                new Product { Id = 3, Name = "Cement Bags", SKU = "BLD-999", Description = "50kg bags", Length = 0.8m, Width = 0.5m, Height = 0.2m, Weight = 50.0m, ClientId = 3 },
                new Product { Id = 4, Name = "Winter Jacket", SKU = "CLTH-WIN-01", Description = "Men's parka", Length = 0.6m, Width = 0.4m, Height = 0.1m, Weight = 1.2m, ClientId = 4 },
                new Product { Id = 5, Name = "Antibiotics X", SKU = "MED-AB-100", Description = "Controlled substance", Length = 0.2m, Width = 0.1m, Height = 0.1m, Weight = 0.5m, ClientId = 5 },
                new Product { Id = 6, Name = "Brake Pads", SKU = "AUTO-BRK-22", Description = "Ceramic pads", Length = 0.3m, Width = 0.2m, Height = 0.1m, Weight = 3.0m, ClientId = 6 },
                new Product { Id = 7, Name = "Industrial Acid", SKU = "CHEM-ACD-05", Description = "Corrosive", Length = 0.4m, Width = 0.4m, Height = 0.6m, Weight = 25.0m, ClientId = 7 },
                new Product { Id = 8, Name = "Lego Set Large", SKU = "TOY-LEG-500", Description = "Construction set", Length = 0.5m, Width = 0.3m, Height = 0.15m, Weight = 1.5m, ClientId = 8 },
                new Product { Id = 9, Name = "Vanilla Ice Cream", SKU = "FOOD-ICE-01", Description = "Keep frozen", Length = 0.2m, Width = 0.15m, Height = 0.1m, Weight = 0.5m, ClientId = 9 },
                new Product { Id = 10, Name = "Gold Watch", SKU = "LUX-WTC-007", Description = "Luxury item", Length = 0.1m, Width = 0.1m, Height = 0.05m, Weight = 0.3m, ClientId = 10 }
            );
        }

        private static void SeedInboundOrders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InboundOrder>().HasData(
                new InboundOrder { Id = 1, Date = new DateTime(2024, 2, 1), Status = "Completed", ClientId = 1 },
                new InboundOrder { Id = 2, Date = new DateTime(2024, 2, 5), Status = "Completed", ClientId = 2 },
                new InboundOrder { Id = 3, Date = new DateTime(2024, 2, 10), Status = "Completed", ClientId = 3 },
                new InboundOrder { Id = 4, Date = new DateTime(2024, 2, 15), Status = "Completed", ClientId = 4 },
                new InboundOrder { Id = 5, Date = new DateTime(2024, 2, 20), Status = "New", ClientId = 5 },
                new InboundOrder { Id = 6, Date = new DateTime(2024, 2, 22), Status = "Completed", ClientId = 6 },
                new InboundOrder { Id = 7, Date = new DateTime(2024, 2, 25), Status = "Processing", ClientId = 7 },
                new InboundOrder { Id = 8, Date = new DateTime(2024, 2, 26), Status = "New", ClientId = 8 },
                new InboundOrder { Id = 9, Date = new DateTime(2024, 2, 27), Status = "Completed", ClientId = 9 },
                new InboundOrder { Id = 10, Date = new DateTime(2024, 2, 28), Status = "New", ClientId = 10 }
            );
        }

        private static void SeedOutboundOrders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OutboundOrder>().HasData(
                new OutboundOrder { Id = 1, Date = new DateTime(2024, 3, 1), Status = "Shipped", ClientId = 1 },
                new OutboundOrder { Id = 2, Date = new DateTime(2024, 3, 2), Status = "Shipped", ClientId = 2 },
                new OutboundOrder { Id = 3, Date = new DateTime(2024, 3, 3), Status = "Pending", ClientId = 3 },
                new OutboundOrder { Id = 4, Date = new DateTime(2024, 3, 4), Status = "Shipped", ClientId = 4 },
                new OutboundOrder { Id = 5, Date = new DateTime(2024, 3, 5), Status = "Cancelled", ClientId = 5 },
                new OutboundOrder { Id = 6, Date = new DateTime(2024, 3, 6), Status = "Pending", ClientId = 6 },
                new OutboundOrder { Id = 7, Date = new DateTime(2024, 3, 7), Status = "Shipped", ClientId = 7 },
                new OutboundOrder { Id = 8, Date = new DateTime(2024, 3, 8), Status = "Packing", ClientId = 8 },
                new OutboundOrder { Id = 9, Date = new DateTime(2024, 3, 9), Status = "Shipped", ClientId = 9 },
                new OutboundOrder { Id = 10, Date = new DateTime(2024, 3, 10), Status = "Pending", ClientId = 10 }
            );
        }

        private static void SeedInventoryItems(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InventoryItem>().HasData(
                new InventoryItem { Id = 1, ProductId = 1, StorageBinId = 1, Quantity = 50, ArrivalDate = new DateTime(2024, 2, 1) },
                new InventoryItem { Id = 2, ProductId = 2, StorageBinId = 4, Quantity = 1000, ArrivalDate = new DateTime(2024, 2, 5) },
                new InventoryItem { Id = 3, ProductId = 3, StorageBinId = 5, Quantity = 200, ArrivalDate = new DateTime(2024, 2, 10) },
                new InventoryItem { Id = 4, ProductId = 4, StorageBinId = 10, Quantity = 150, ArrivalDate = new DateTime(2024, 2, 15) },
                new InventoryItem { Id = 5, ProductId = 5, StorageBinId = 3, Quantity = 500, ArrivalDate = new DateTime(2024, 2, 22) },
                new InventoryItem { Id = 6, ProductId = 6, StorageBinId = 2, Quantity = 80, ArrivalDate = new DateTime(2024, 2, 22) },
                new InventoryItem { Id = 7, ProductId = 7, StorageBinId = 6, Quantity = 20, ArrivalDate = new DateTime(2024, 2, 25) },
                new InventoryItem { Id = 8, ProductId = 8, StorageBinId = 2, Quantity = 60, ArrivalDate = new DateTime(2024, 2, 27) },
                new InventoryItem { Id = 9, ProductId = 9, StorageBinId = 9, Quantity = 300, ArrivalDate = new DateTime(2024, 2, 27) },
                new InventoryItem { Id = 10, ProductId = 10, StorageBinId = 3, Quantity = 10, ArrivalDate = new DateTime(2024, 3, 1) }
            );
        }

        private static void SeedStockMovements(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StockMovement>().HasData(
                new StockMovement { Id = 1, Type = "Inbound", MovementDate = new DateTime(2024, 2, 1), Quantity = 50, ProductId = 1, FromBinId = null, ToBinId = 1 },
                new StockMovement { Id = 2, Type = "Inbound", MovementDate = new DateTime(2024, 2, 5), Quantity = 1000, ProductId = 2, FromBinId = null, ToBinId = 4 },
                new StockMovement { Id = 3, Type = "Inbound", MovementDate = new DateTime(2024, 2, 10), Quantity = 200, ProductId = 3, FromBinId = null, ToBinId = 5 },
                new StockMovement { Id = 4, Type = "Outbound", MovementDate = new DateTime(2024, 3, 1), Quantity = 5, ProductId = 1, FromBinId = 1, ToBinId = null },
                new StockMovement { Id = 5, Type = "Relocation", MovementDate = new DateTime(2024, 3, 2), Quantity = 10, ProductId = 2, FromBinId = 4, ToBinId = 8 },
                new StockMovement { Id = 6, Type = "Inbound", MovementDate = new DateTime(2024, 2, 22), Quantity = 500, ProductId = 5, FromBinId = null, ToBinId = 3 },
                new StockMovement { Id = 7, Type = "Outbound", MovementDate = new DateTime(2024, 3, 4), Quantity = 2, ProductId = 4, FromBinId = 10, ToBinId = null },
                new StockMovement { Id = 8, Type = "Inbound", MovementDate = new DateTime(2024, 2, 25), Quantity = 20, ProductId = 7, FromBinId = null, ToBinId = 6 },
                new StockMovement { Id = 9, Type = "Relocation", MovementDate = new DateTime(2024, 3, 5), Quantity = 5, ProductId = 6, FromBinId = 2, ToBinId = 1 },
                new StockMovement { Id = 10, Type = "Outbound", MovementDate = new DateTime(2024, 3, 10), Quantity = 1, ProductId = 10, FromBinId = 3, ToBinId = null }
            );
        }

        private static void SeedBillingRecords(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BillingRecord>().HasData(
                new BillingRecord { Id = 1, ClientId = 1, BillingDate = new DateTime(2024, 3, 1), PeriodStart = new DateTime(2024, 2, 1), PeriodEnd = new DateTime(2024, 2, 29), TotalAmount = 1500.00m, Description = "Feb Storage" },
                new BillingRecord { Id = 2, ClientId = 2, BillingDate = new DateTime(2024, 3, 1), PeriodStart = new DateTime(2024, 2, 1), PeriodEnd = new DateTime(2024, 2, 29), TotalAmount = 3000.00m, Description = "Feb Cold Chain" },
                new BillingRecord { Id = 3, ClientId = 3, BillingDate = new DateTime(2024, 3, 1), PeriodStart = new DateTime(2024, 2, 1), PeriodEnd = new DateTime(2024, 2, 29), TotalAmount = 500.00m, Description = "Feb Bulk" },
                new BillingRecord { Id = 4, ClientId = 4, BillingDate = new DateTime(2024, 3, 1), PeriodStart = new DateTime(2024, 2, 1), PeriodEnd = new DateTime(2024, 2, 29), TotalAmount = 200.00m, Description = "Feb Retail" },
                new BillingRecord { Id = 5, ClientId = 5, BillingDate = new DateTime(2024, 3, 1), PeriodStart = new DateTime(2024, 2, 1), PeriodEnd = new DateTime(2024, 2, 29), TotalAmount = 2500.00m, Description = "Feb Secure" },
                new BillingRecord { Id = 6, ClientId = 6, BillingDate = new DateTime(2024, 3, 1), PeriodStart = new DateTime(2024, 2, 1), PeriodEnd = new DateTime(2024, 2, 29), TotalAmount = 450.00m, Description = "Feb Parts" },
                new BillingRecord { Id = 7, ClientId = 7, BillingDate = new DateTime(2024, 3, 1), PeriodStart = new DateTime(2024, 2, 1), PeriodEnd = new DateTime(2024, 2, 29), TotalAmount = 5000.00m, Description = "Feb Hazardous" },
                new BillingRecord { Id = 8, ClientId = 8, BillingDate = new DateTime(2024, 3, 1), PeriodStart = new DateTime(2024, 2, 1), PeriodEnd = new DateTime(2024, 2, 29), TotalAmount = 800.00m, Description = "Feb E-comm" },
                new BillingRecord { Id = 9, ClientId = 9, BillingDate = new DateTime(2024, 3, 1), PeriodStart = new DateTime(2024, 2, 1), PeriodEnd = new DateTime(2024, 2, 29), TotalAmount = 1200.00m, Description = "Feb Frozen" },
                new BillingRecord { Id = 10, ClientId = 10, BillingDate = new DateTime(2024, 3, 1), PeriodStart = new DateTime(2024, 2, 1), PeriodEnd = new DateTime(2024, 2, 29), TotalAmount = 10000.00m, Description = "Feb VIP" }
            );
        }
    }
}