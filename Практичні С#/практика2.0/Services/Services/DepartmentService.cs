using Data.Models;
using Repositories.Base;
using Repositories.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class DepartmentService
    {
        private readonly DepartmentRepository _repository;

        public DepartmentService(DepartmentRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _repository.GetAll();
        }

        public void AddDepartment(string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Department name can't be null");
            }

            var department = new Department
            {
                DepartmentName = name.Trim(),
                Description = description?.Trim(),
                CreatedAt = DateTime.Now
            };

            _repository.Add(department);
        }

        public void UpdateDepartment(Department department, string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Department name can't be null");
            }

            department.DepartmentName = name.Trim();
            department.Description = description?.Trim();

            _repository.Update(department);
        }

        public void DeleteDepartment(int id)
        {
            _repository.Delete(id);
        }
    }
}
