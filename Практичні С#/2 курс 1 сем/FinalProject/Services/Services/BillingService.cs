using System;
using System.Collections.Generic;
using System.Linq;
using Data.Models;
using Repositories.Main;

namespace Services
{
    public class BillingRecordService
    {
        private readonly BillingRecordRepo _billRepo;
        private readonly InventoryItemRepo _invRepo;
        private readonly ClientRepo _clientRepo;

        public BillingRecordService(BillingRecordRepo b, InventoryItemRepo i, ClientRepo c)
        {
            _billRepo = b; 
            _invRepo = i; 
            _clientRepo = c;
        }

        public IEnumerable<BillingRecord> GetAll()
        {
            return _billRepo.GetAll();
        }

        public void GenerateInvoice(int clientId, DateTime start, DateTime end)
        {
            if (start > end)
            {
                throw new ArgumentException("Start date cannot be later than End date.");
            }

            var client = _clientRepo.GetById(clientId);

            if (client == null)
            {
                throw new Exception("Client not found.");
            }

            if (client.TariffPlan == null)
            {
                throw new Exception("Client has no Tariff Plan assigned.");
            }
            var inventory = _invRepo.GetAll().Where(x => x.Product.ClientId == clientId).ToList();

            if (!inventory.Any())
            {
                throw new Exception("No inventory found for this client to bill.");
            }

            decimal totalAmount = 0;

            foreach (var item in inventory)
            {
                DateTime effectiveStart = item.ArrivalDate > start ? item.ArrivalDate : start;
                if (effectiveStart > end) continue;

                int days = (end - effectiveStart).Days + 1;

                if (days <= 0)
                {
                    continue;
                }

                decimal unitVolume = item.Product.Length * item.Product.Width * item.Product.Height;

                decimal totalVolume = unitVolume * item.Quantity;

                decimal cost = totalVolume * days * client.TariffPlan.DailyStorageCostPerCubicMeter;

                totalAmount += cost;
            }

            var bill = new BillingRecord
            {
                ClientId = clientId,
                PeriodStart = start,
                PeriodEnd = end,
                BillingDate = DateTime.Now,
                TotalAmount = Math.Round(totalAmount, 2), 
                Description = $"Storage Invoice ({start:d} - {end:d})"
            };

            _billRepo.Add(bill);
        }
    }
}
