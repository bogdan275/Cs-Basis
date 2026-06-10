using Data.Models;
using Repositories.Base;
using Repositories.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _employeeRepo;
        private readonly DepartmentRepository _departmentRepo;
        private readonly SpecializationRepository _specializationRepo;

        public EmployeeService(
            EmployeeRepository employeeRepo,
            DepartmentRepository departmentRepo,
            SpecializationRepository specializationRepo)
        {
            _employeeRepo = employeeRepo;
            _departmentRepo = departmentRepo;
            _specializationRepo = specializationRepo;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeRepo.GetAll();
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _departmentRepo.GetAll();
        }

        public IEnumerable<Specialization> GetAllSpecializations()
        {
            return _specializationRepo.GetAll();
        }

        public IEnumerable<Employee> GetEligibleEmployeesForCategory(int categoryId)
        {
            return _employeeRepo.GetByServiceCategory(categoryId);
        }

        public void AddEmployee(Employee employee)
        {
            if (string.IsNullOrWhiteSpace(employee.FullName))
            {
                throw new ArgumentException("Employee name can't be null");
            }

            if (string.IsNullOrWhiteSpace(employee.Position))
            {
                throw new ArgumentException("Position name can't be null");
            }

            _employeeRepo.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            if (string.IsNullOrWhiteSpace(employee.FullName))
            {
                throw new ArgumentException("Employee name can't be null");
            }

            if (string.IsNullOrWhiteSpace(employee.Position))
            {
                throw new ArgumentException("Position name can't be null");
            }

            _employeeRepo.Update(employee);
        }

        public void DeleteEmployee(int id)
        {
            _employeeRepo.Delete(id);
        }
    }
}
