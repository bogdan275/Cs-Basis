using System;
using System.Collections.Generic;
using System.Text;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class FinalProjectContext  : DbContext
    {
        public DbSet<Warehouse> Warehouses => Set<Warehouse>();
        public DbSet<StorageZone> StorageZones => Set<StorageZone>();
        public DbSet<StorageBin> StorageBins => Set<StorageBin>();

        public DbSet<Client> Clients => Set<Client>();
        public DbSet<TariffPlan> TariffPlans => Set<TariffPlan>();

        public DbSet<Product> Products => Set<Product>();
        public DbSet<InventoryItem> InventoryItems => Set<InventoryItem>();

        public DbSet<InboundOrder> InboundOrders => Set<InboundOrder>();
        public DbSet<OutboundOrder> OutboundOrders => Set<OutboundOrder>();
        public DbSet<StockMovement> StockMovements => Set<StockMovement>();
        public DbSet<BillingRecord> BillingRecords => Set<BillingRecord>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var cnstring = "Server=.;Database=FinalProject;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(cnstring);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SeedFinalProjectData();
        }
    }
}
