using System;
using System.Collections.Generic;
using Data.Models;
using Repositories.Reporitories;

namespace Services
{
    public class PurchaseOrderItemService
    {
        private readonly IRepository<Purchase_Order_Item> _itemRepo;
        private readonly IRepository<Purchase_Order> _orderRepo;
        private readonly IRepository<Medicine> _medicineRepo;

        public PurchaseOrderItemService(
            IRepository<Purchase_Order_Item> itemRepo,
            IRepository<Purchase_Order> orderRepo,
            IRepository<Medicine> medicineRepo)
        {
            _itemRepo = itemRepo;
            _orderRepo = orderRepo;
            _medicineRepo = medicineRepo;
        }

        public IEnumerable<Purchase_Order_Item> GetAllItems()
        {
            return _itemRepo.GetAll();
        }
        public IEnumerable<Purchase_Order> GetAllOrders()
        {
            return _orderRepo.GetAll();
        }
        public IEnumerable<Medicine> GetAllMedicines()
        {
            return _medicineRepo.GetAll();
        }

        public void AddOrderItem(Purchase_Order_Item item)
        {
            if (item.Quantity <= 0)
            {
                throw new ArgumentException("Quantity must be greater than 0.");
            }

            _itemRepo.Add(item);
        }

        public void UpdateOrderItem(Purchase_Order_Item item)
        {
            if (item.Quantity <= 0)
            {
                throw new ArgumentException("Quantity must be greater than 0.");
            }

            _itemRepo.Update(item);
        }

        public void DeleteOrderItem(int id)
        {
            _itemRepo.Delete(id);
        }
    }
}