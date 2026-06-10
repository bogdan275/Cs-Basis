using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Main
{
    public class MonitoringCheckRepository : Repository<MonitoringCheck>
    {
        public MonitoringCheckRepository(MonitoringContext context) : base(context) { }

        public override IEnumerable<MonitoringCheck> GetAll()
        {
            return _context.MonitoringChecks
                .Include(mc => mc.Service)
                .OrderByDescending(mc => mc.CheckDateTime)
                .Take(1000) 
                .ToList();
        }

        public IEnumerable<MonitoringCheck> GetByService(int serviceId, int count = 100)
        {
            return _context.MonitoringChecks
                .Where(mc => mc.ServiceId == serviceId)
                .OrderByDescending(mc => mc.CheckDateTime)
                .Take(count)
                .ToList();
        }

        public IEnumerable<MonitoringCheck> GetByDateRange(int serviceId, DateTime from, DateTime to)
        {
            return _context.MonitoringChecks
                .Where(mc => mc.ServiceId == serviceId
                          && mc.CheckDateTime >= from
                          && mc.CheckDateTime <= to)
                .OrderBy(mc => mc.CheckDateTime)
                .ToList();
        }

        public IEnumerable<MonitoringCheck> GetFailedChecks(int serviceId)
        {
            return _context.MonitoringChecks
                .Where(mc => mc.ServiceId == serviceId
                          && (mc.Status == "Error" || mc.Status == "Timeout"))
                .OrderByDescending(mc => mc.CheckDateTime)
                .Take(50)
                .ToList();
        }
    }
}
