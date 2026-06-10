using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Main
{
    public class MaintenanceWindowRepository : Repository<MaintenanceWindow>
    {
        public MaintenanceWindowRepository(MonitoringContext context) : base(context) { }

        public override IEnumerable<MaintenanceWindow> GetAll()
        {
            return _context.MaintenanceWindows
                .Include(m => m.Service)
                .Include(m => m.ScheduledByEmployee)
                .OrderByDescending(m => m.StartDateTime)
                .ToList();
        }

        public override MaintenanceWindow GetById(int id)
        {
            return _context.MaintenanceWindows
                .Include(m => m.Service)
                .Include(m => m.ScheduledByEmployee)
                    .ThenInclude(e => e.Department)
                .FirstOrDefault(m => m.MaintenanceId == id);
        }

        public bool IsInMaintenanceWindow(int serviceId, DateTime checkTime)
        {
            return _context.MaintenanceWindows
                .Any(m => m.ServiceId == serviceId
                       && m.Status == "InProgress"
                       && m.StartDateTime <= checkTime
                       && m.EndDateTime >= checkTime);
        }

        public IEnumerable<MaintenanceWindow> GetScheduledMaintenances()
        {
            return _context.MaintenanceWindows
                .Include(m => m.Service)
                .Include(m => m.ScheduledByEmployee)
                .Where(m => m.Status == "Scheduled")
                .OrderBy(m => m.StartDateTime)
                .ToList();
        }
    }
}
