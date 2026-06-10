using System;
using System.Collections.Generic;
using Data.Models;
using Repositories.Reporitories;

namespace Services
{
    public class BrandService
    {
        private readonly IRepository<Brand> _repository;

        public BrandService(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Brand> GetAllBrands()
        {
            return _repository.GetAll();
        }

        public void AddBrand(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Brand name cannot be empty.");
            }

            var newBrand = new Brand { Name = name };
            _repository.Add(newBrand);
        }

        public void UpdateBrand(Brand brand, string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new ArgumentException("Brand name cannot be empty.");
            }

            brand.Name = newName;
            _repository.Update(brand);
        }

        public void DeleteBrand(int id)
        {
            _repository.Delete(id);
        }
    }
}