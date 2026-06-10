using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Main
{
    public class ServiceRepository : Repository<Service>
    {
        public ServiceRepository(MonitoringContext context) : base(context) { }

        public override IEnumerable<Service> GetAll()
        {
            return _context.Services
                .Include(s => s.Category)
                .Include(s => s.ResponsibleEmployee)
                .OrderBy(s => s.ServiceName)
                .ToList();
        }

        public override Service GetById(int id)
        {
            return _context.Services
                .Include(s => s.Category)
                .Include(s => s.ResponsibleEmployee)
                    .ThenInclude(e => e.Department)
                .Include(s => s.Dependencies)
                    .ThenInclude(d => d.DependsOnService)
                .Include(s => s.DependentServices)
                    .ThenInclude(d => d.Service)
                .FirstOrDefault(s => s.ServiceId == id);
        }

        public IEnumerable<Service> GetActiveServices()
        {
            return _context.Services
                .Include(s => s.Category)
                .Include(s => s.ResponsibleEmployee)
                .Where(s => s.IsActive)
                .OrderBy(s => s.ServiceName)
                .ToList();
        }

        public IEnumerable<Service> GetCriticalServices()
        {
            return _context.Services
                .Include(s => s.Category)
                .Include(s => s.ResponsibleEmployee)
                .Where(s => s.Criticality == "Critical" || s.Criticality == "High")
                .OrderBy(s => s.ServiceName)
                .ToList();
        }
    }
}
