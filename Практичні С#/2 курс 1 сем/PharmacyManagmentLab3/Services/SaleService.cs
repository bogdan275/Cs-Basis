using System;
using System.Collections.Generic;
using System.Linq;
using Data.Models;
using Repositories.Reporitories;

namespace Services
{
    public class SaleService
    {
        private readonly IRepository<Sale> _saleRepo;
        private readonly IRepository<Medicine> _medicineRepo;
        private readonly IRepository<Batch> _batchRepo;

        public SaleService(
            IRepository<Sale> saleRepo,
            IRepository<Medicine> medicineRepo,
            IRepository<Batch> batchRepo)
        {
            _saleRepo = saleRepo;
            _medicineRepo = medicineRepo;
            _batchRepo = batchRepo;
        }

        public IEnumerable<Sale> GetAllSales()
        {
            return _saleRepo.GetAll();
        }

        public IEnumerable<Medicine> GetAllMedicines()
        {
            return _medicineRepo.GetAll();
        }

        public IEnumerable<Batch> GetAvailableBatches(int medicineId)
        {
            return _batchRepo.GetAll()
                .Where(b => b.MedicineId == medicineId && b.Stock_Quantity > 0)
                .OrderBy(b => b.Expiri_Date);
        }

        public void AddSale(Sale sale)
        {
            if (string.IsNullOrEmpty(sale.Customer_Name))
            {
                throw new Exception("Customer Name is required.");
            }

            var batch = _batchRepo.GetById(sale.BatchId);

            if (batch == null)
            {
                throw new Exception("Selected batch not found.");
            }

            if (batch.Stock_Quantity < sale.Quantity)
            {
                throw new Exception($"Not enough stock. Available: {batch.Stock_Quantity}");
            }

            sale.Price = Math.Round(batch.Unit_Price_Per_Item * sale.Quantity, 2);

            batch.Stock_Quantity -= sale.Quantity;
            _batchRepo.Update(batch);

            _saleRepo.Add(sale);
        }

        public void UpdateSale(Sale sale)
        {
            if (string.IsNullOrEmpty(sale.Customer_Name))
            {
                throw new Exception("Customer Name is required.");
            }
            _saleRepo.Update(sale);
        }

        public void DeleteSale(int saleId)
        {
            var sale = _saleRepo.GetById(saleId);
            if (sale != null)
            {
                var batch = _batchRepo.GetById(sale.BatchId);
                if (batch != null)
                {
                    batch.Stock_Quantity += sale.Quantity;
                    _batchRepo.Update(batch);
                }
                _saleRepo.Delete(saleId);
            }
        }
    }
}