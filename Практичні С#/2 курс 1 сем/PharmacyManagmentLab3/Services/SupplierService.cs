using System;
using System.Collections.Generic;
using Data.Models;
using Repositories.Reporitories;

namespace Services
{
    public class SupplierService
    {
        private readonly IRepository<Supplier> _repository;

        public SupplierService(IRepository<Supplier> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return _repository.GetAll();
        }

        public void AddSupplier(string name, string phone)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone))
            {
                throw new ArgumentException("Please enter a valid supplier name and phone.");
            }

            var newSupplier = new Supplier
            {
                SupplierName = name.Trim(),
                Phone = phone.Trim()
            };

            _repository.Add(newSupplier);
        }

        public void UpdateSupplier(Supplier supplier, string name, string phone)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone))
            {
                throw new ArgumentException("Please enter a valid supplier name and phone.");
            }

            supplier.SupplierName = name.Trim();
            supplier.Phone = phone.Trim();

            _repository.Update(supplier);
        }

        public void DeleteSupplier(int id)
        {
            _repository.Delete(id);
        }
    }
}