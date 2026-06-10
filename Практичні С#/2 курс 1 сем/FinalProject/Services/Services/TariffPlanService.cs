using System;
using System.Collections.Generic;
using Data.Models;
using Repositories.Main;

namespace Services
{
    public class TariffPlanService
    {
        private readonly TariffPlanRepo _repo;

        public TariffPlanService(TariffPlanRepo repo)
        {
            _repo = repo;
        }

        public IEnumerable<TariffPlan> GetAll()
        {
            return _repo.GetAll();
        }

        public void Create(string name, decimal dailyCost, decimal handlingFee)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Tariff Name cannot be empty."); 
            }

            if (dailyCost < 0)
            {
                throw new ArgumentException("Price cannot be negative.");
            }

            if (handlingFee < 0)
            {
                throw new ArgumentException("Handling fee cannot be negative.");
            }
                

            var newTariff = new TariffPlan
            {
                Name = name,
                DailyStorageCostPerCubicMeter = dailyCost,
                HandlingFeePerUnit = handlingFee
            };

            _repo.Add(newTariff);
        }

        public void Update(TariffPlan tariff, string newName, decimal newDailyCost, decimal newHandlingFee)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new ArgumentException("Tariff Name cannot be empty.");
            }

            if (newDailyCost < 0 || newHandlingFee < 0)
            {
                throw new ArgumentException("Prices cannot be negative.");
            }

            tariff.Name = newName;
            tariff.DailyStorageCostPerCubicMeter = newDailyCost;
            tariff.HandlingFeePerUnit = newHandlingFee;

            _repo.Update(tariff);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }
    }
}