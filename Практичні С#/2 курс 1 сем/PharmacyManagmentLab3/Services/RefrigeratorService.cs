using System;
using System.Collections.Generic;
using Data.Models;
using Repositories.Reporitories;

namespace Services
{
    public class RefrigeratorService
    {
        private readonly IRepository<Refrigerator> _repository;

        public RefrigeratorService(IRepository<Refrigerator> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Refrigerator> GetAllRefrigerators()
        {
            return _repository.GetAll();
        }

        public void AddRefrigerator(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Please enter a valid refrigerator name.");
            }

            var newRefrigerator = new Refrigerator
            {
                Refrigerator_Name = name.Trim()
            };

            _repository.Add(newRefrigerator);
        }

        public void UpdateRefrigerator(Refrigerator refrigerator, string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new ArgumentException("Please enter a valid refrigerator name.");
            }

            refrigerator.Refrigerator_Name = newName.Trim();
            _repository.Update(refrigerator);
        }

        public void DeleteRefrigerator(int id)
        {
            _repository.Delete(id);
        }
    }
}