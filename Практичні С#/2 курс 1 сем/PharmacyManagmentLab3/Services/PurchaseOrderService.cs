using System;
using System.Collections.Generic;
using Data.Models;
using Repositories.Reporitories;

namespace Services
{
    public class PurchaseOrderService
    {
        private readonly IRepository<Purchase_Order> _orderRepo;
        private readonly IRepository<Supplier> _supplierRepo;

        public PurchaseOrderService(
            IRepository<Purchase_Order> orderRepo,
            IRepository<Supplier> supplierRepo)
        {
            _orderRepo = orderRepo;
            _supplierRepo = supplierRepo;
        }

        public IEnumerable<Purchase_Order> GetAllOrders()
        {
            return _orderRepo.GetAll();
        }
        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return _supplierRepo.GetAll();
        }

        public void AddOrder(Purchase_Order order)
        {
            _orderRepo.Add(order);
        }

        public void UpdateOrder(Purchase_Order order)
        {
            _orderRepo.Update(order);
        }

        public void DeleteOrder(int id)
        {
            _orderRepo.Delete(id);
        }
    }
}