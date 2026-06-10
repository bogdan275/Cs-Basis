using System;
using System.Collections.Generic;
using Data.Models;
using Repositories.ForModels;
using Repositories.Reporitories; 

namespace Services
{
    public class BatchService
    {
        private readonly BatchRepository _batchRepo;
        private readonly MedicineRepository _medicineRepo;
        private readonly PurchaseOrderRepository _orderRepo;
        private readonly RefrigeratorRepository _fridgeRepo;

        public BatchService(
            BatchRepository batchRepo,
            MedicineRepository medicineRepo,
            PurchaseOrderRepository orderRepo,
            RefrigeratorRepository fridgeRepo)
        {
            _batchRepo = batchRepo;
            _medicineRepo = medicineRepo;
            _orderRepo = orderRepo;
            _fridgeRepo = fridgeRepo;
        }

        public IEnumerable<Batch> GetAllBatches()
        {
            return _batchRepo.GetAll();
        }
        public IEnumerable<Medicine> GetMedicines()
        {
            return _medicineRepo.GetAll();
        }
        public IEnumerable<Purchase_Order> GetOrders()
        {
            return _orderRepo.GetAll();
        }
        public IEnumerable<Refrigerator> GetRefrigerators()
        {
            return _fridgeRepo.GetAll();
        }

        public void AddBatch(Batch batch)
        {
            if (string.IsNullOrEmpty(batch.Batch_Num) || batch.Stock_Quantity == 0)
            {
                throw new Exception("Please fill in all fields correctly.");
            }

            _batchRepo.Add(batch);
        }

        public void UpdateBatch(Batch batch)
        {
            if (string.IsNullOrEmpty(batch.Batch_Num))
            {
                throw new Exception("Batch Number cannot be empty.");
            }
            _batchRepo.Update(batch);
        }

        public void DeleteBatch(int id)
        {
            _batchRepo.Delete(id);
        }
    }
}