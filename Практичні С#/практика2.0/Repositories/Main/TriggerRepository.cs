using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Main
{
    public class TriggerRepository : Repository<Trigger>
    {
        public TriggerRepository(MonitoringContext context) : base(context) { }

        public override IEnumerable<Trigger> GetAll()
        {
            return _context.Triggers
                .Include(t => t.Service)
                .Include(t => t.IncidentSeverity)
                .OrderBy(t => t.Service.ServiceName)
                .ThenBy(t => t.TriggerName)
                .ToList();
        }

        public override Trigger GetById(int id)
        {
            return _context.Triggers
                .Include(t => t.Service)
                .Include(t => t.IncidentSeverity)
                .FirstOrDefault(t => t.TriggerId == id);
        }

        public IEnumerable<Trigger> GetActiveTriggersForService(int serviceId)
        {
            return _context.Triggers
                .Include(t => t.IncidentSeverity)
                .Where(t => t.ServiceId == serviceId && t.IsEnabled)
                .ToList();
        }
    }
}
