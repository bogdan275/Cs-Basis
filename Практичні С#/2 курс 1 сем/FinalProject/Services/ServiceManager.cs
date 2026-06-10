using System;
using Data;
using Repositories.Main;

namespace Services
{
    public class ServiceManager 
    {
        private readonly FinalProjectContext _context;

        public WarehouseService WarehouseService { get; private set; }
        public StorageZoneService StorageZoneService { get; private set; }
        public StorageBinService StorageBinService { get; private set; }

        public TariffPlanService TariffPlanService { get; private set; }
        public ClientService ClientService { get; private set; }
        public ProductService ProductService { get; private set; }

        public InventoryItemService InventoryItemService { get; private set; }
        public StockMovementService StockMovementService { get; private set; }
        public BillingRecordService BillingRecordService { get; private set; }

        public ServiceManager()
        {
            _context = new FinalProjectContext();

            var warehouseRepo = new WarehouseRepo(_context);
            var zoneRepo = new StorageZoneRepo(_context);
            var binRepo = new StorageBinRepo(_context);

            var tariffRepo = new TariffPlanRepo(_context);
            var clientRepo = new ClientRepo(_context);
            var productRepo = new ProductRepo(_context);

            var inventoryRepo = new InventoryItemRepo(_context);
            var movementRepo = new StockMovementRepo(_context);
            var billingRepo = new BillingRecordRepo(_context);

            WarehouseService = new WarehouseService(warehouseRepo);
            StorageZoneService = new StorageZoneService(zoneRepo, warehouseRepo);
            StorageBinService = new StorageBinService(binRepo, zoneRepo);

            TariffPlanService = new TariffPlanService(tariffRepo);
            ClientService = new ClientService(clientRepo, tariffRepo);
            ProductService = new ProductService(productRepo, clientRepo); 

            InventoryItemService = new InventoryItemService(inventoryRepo, movementRepo);
            StockMovementService = new StockMovementService(movementRepo);
            BillingRecordService = new BillingRecordService(billingRepo, inventoryRepo, clientRepo);
        }
    }
}