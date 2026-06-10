using System;
using System.Collections.Generic;
using Data.Models;
using Repositories.Main;

namespace Services
{
    public class WarehouseService
    {
        private readonly WarehouseRepo _repo;

        public WarehouseService(WarehouseRepo repo)
        {
            _repo = repo;
        }

        public IEnumerable<Warehouse> GetAll()
        {
            return _repo.GetAll();
        }

        public void Create(string name, string adress)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Please enter a valid warehouse name.");
            }

            var newWarehouse = new Warehouse
            {
                Name = name,
                Address = adress,
            };
            _repo.Add(newWarehouse);
        }

        public void Update(Warehouse warehouse, string newName, string adress)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new ArgumentException("Please enter a valid warehouse name.");
            }

            warehouse.Name = newName;
            warehouse.Address = adress;
            _repo.Update(warehouse);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }
    }
}