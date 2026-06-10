using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Main
{
    public class EmployeeRepository : Repository<Employee>
    {
        public EmployeeRepository(MonitoringContext context) : base(context) { }

        public override IEnumerable<Employee> GetAll()
        {
            return _context.Employees
                .Include(e => e.Department)
                .Include(e => e.Specialization)
                .ToList();
        }

        public override Employee GetById(int id)
        {
            return _context.Employees
                .Include(e => e.Department)
                .Include(e => e.Specialization)
                .FirstOrDefault(e => e.EmployeeId == id);
        }

        public IEnumerable<Employee> GetByServiceCategory(int categoryId)
        {
            return _context.Employees
                .Include(e => e.Specialization)
                    .ThenInclude(s => s.SpecializationCategories)
                .Where(e => e.Specialization.SpecializationCategories
                    .Any(sc => sc.CategoryId == categoryId))
                .OrderBy(e => e.FullName)
                .ToList();
        }
    }
}
