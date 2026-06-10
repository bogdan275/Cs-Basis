using System;
using System.Collections.Generic;
using Data.Models;
using Repositories.Main;

namespace Services
{
    public class StorageZoneService
    {
        private readonly StorageZoneRepo _zoneRepo;
        private readonly WarehouseRepo _whRepo;

        public StorageZoneService(StorageZoneRepo zoneRepo, WarehouseRepo whRepo)
        {
            _zoneRepo = zoneRepo;
            _whRepo = whRepo;
        }

        public IEnumerable<StorageZone> GetAll()
        {
            return _zoneRepo.GetAll();
        }

        public IEnumerable<Warehouse> GetWarehouses()
        {
            return _whRepo.GetAll();
        }

        public void Create(string name, decimal costMultiplier, int warehouseId)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Zone name is required.");

            if (warehouseId <= 0)
                throw new ArgumentException("Please select a warehouse.");

            if (costMultiplier < 1)
                throw new ArgumentException("Cost multiplier must be >= 1.");

            var newZone = new StorageZone
            {
                Name = name,
                CostMultiplier = costMultiplier,
                WarehouseId = warehouseId
            };

            _zoneRepo.Add(newZone);
        }

        public void Update(StorageZone zone, string newName, decimal newCost, int newWarehouseId)
        {
            if (string.IsNullOrWhiteSpace(newName))
                throw new ArgumentException("Zone name is required.");

            if (newWarehouseId <= 0)
                throw new ArgumentException("Please select a warehouse.");

            zone.Name = newName;
            zone.CostMultiplier = newCost;
            zone.WarehouseId = newWarehouseId;

            _zoneRepo.Update(zone);
        }

        public void Delete(int id)
        {
            _zoneRepo.Delete(id);
        }
    }
}