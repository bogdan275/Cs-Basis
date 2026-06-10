using Data.Models;
using Repositories.Base;
using Repositories.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class ServiceCategoryService
    {
        private readonly ServiceCategoryRepository _repository;

        public ServiceCategoryService(ServiceCategoryRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ServiceCategory> GetAllCategories()
        {
            return _repository.GetAll();
        }

        public void AddCategory(string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Service category name can't be null");
            }

            var category = new ServiceCategory
            {
                CategoryName = name.Trim(),
                Description = description?.Trim()
            };

            _repository.Add(category);
        }

        public void UpdateCategory(ServiceCategory category, string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Service category name can't be null");
            }

            category.CategoryName = name.Trim();
            category.Description = description?.Trim();

            _repository.Update(category);
        }

        public void DeleteCategory(int id)
        {
            _repository.Delete(id);
        }
    }
}
