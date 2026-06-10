using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Main
{
    public class IncidentRepository : Repository<Incident>
    {
        public IncidentRepository(MonitoringContext context) : base(context) { }

        public override IEnumerable<Incident> GetAll()
        {
            return _context.Incidents
                .Include(i => i.Service)
                .Include(i => i.Severity)
                .Include(i => i.AssignedToEmployee)
                .Include(i => i.TriggeredByTrigger)
                .OrderByDescending(i => i.DetectedAt)
                .ToList();
        }

        public override Incident GetById(int id)
        {
            return _context.Incidents
                .Include(i => i.Service)
                .Include(i => i.Severity)
                .Include(i => i.AssignedToEmployee)
                    .ThenInclude(e => e.Department)
                .Include(i => i.TriggeredByTrigger)
                .Include(i => i.Comments)
                    .ThenInclude(c => c.Employee)
                .FirstOrDefault(i => i.IncidentId == id);
        }

        public IEnumerable<Incident> GetActiveIncidents()
        {
            return _context.Incidents
                .Include(i => i.Service)
                .Include(i => i.Severity)
                .Include(i => i.AssignedToEmployee)
                .Where(i => i.Status == "New" || i.Status == "InProgress")
                .OrderByDescending(i => i.DetectedAt)
                .ToList();
        }

        public IEnumerable<Incident> GetByStatus(string status)
        {
            return _context.Incidents
                .Include(i => i.Service)
                .Include(i => i.Severity)
                .Include(i => i.AssignedToEmployee)
                .Where(i => i.Status == status)
                .OrderByDescending(i => i.DetectedAt)
                .ToList();
        }

        public IEnumerable<Incident> GetByService(int serviceId)
        {
            return _context.Incidents
                .Include(i => i.Severity)
                .Include(i => i.AssignedToEmployee)
                .Where(i => i.ServiceId == serviceId)
                .OrderByDescending(i => i.DetectedAt)
                .ToList();
        }
    }
}
