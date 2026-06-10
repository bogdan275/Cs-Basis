using System;
using System.Collections.Generic;
using Data.Models;
using Repositories.Main;

namespace Services
{
    public class StorageBinService
    {
        private readonly StorageBinRepo _binRepo;
        private readonly StorageZoneRepo _zoneRepo;

        public StorageBinService(StorageBinRepo binRepo, StorageZoneRepo zoneRepo)
        {
            _binRepo = binRepo;
            _zoneRepo = zoneRepo;
        }

        public IEnumerable<StorageBin> GetAll()
        {
            return _binRepo.GetAll();
        }
        public IEnumerable<StorageZone> GetZones()
        {
            return _zoneRepo.GetAll();
        }

        public void Create(string code, decimal maxWeight, decimal maxVol, int zoneId)
        {
            if (string.IsNullOrWhiteSpace(code)) 
            {
                throw new ArgumentException("Bin code is required.");
            }

            if (zoneId <= 0)
            {
                throw new ArgumentException("Please select a zone.");
            }

            if (maxWeight <= 0 || maxVol <= 0)
            {
                throw new ArgumentException("Limits must be greater than 0.");
            }

            var newBin = new StorageBin
            {
                Code = code,
                MaxWeight = maxWeight,
                MaxVolume = maxVol,
                StorageZoneId = zoneId
            };

            _binRepo.Add(newBin);
        }

        public void Update(StorageBin bin, string newCode, decimal newWeight, decimal newVol, int newZoneId)
        {
            if (string.IsNullOrWhiteSpace(newCode))
            {
                throw new ArgumentException("Bin code is required.");
            }

            if (newZoneId <= 0)
            {
                throw new ArgumentException("Please select a zone.");
            }


            bin.Code = newCode;
            bin.MaxWeight = newWeight;
            bin.MaxVolume = newVol;
            bin.StorageZoneId = newZoneId;

            _binRepo.Update(bin);
        }

        public void Delete(int id)
        {
            _binRepo.Delete(id);
        }
    }
}