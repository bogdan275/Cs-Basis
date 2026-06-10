using Data.Models;
using Repositories.Base;
using Repositories.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class AuditLogService
    {
        private readonly AuditLogRepository _auditRepo;
        private readonly EmployeeRepository _employeeRepo;

        public AuditLogService(AuditLogRepository auditRepo, EmployeeRepository employeeRepo)
        {
            _auditRepo = auditRepo;
            _employeeRepo = employeeRepo;
        }

        public IEnumerable<AuditLog> GetAllLogs()
        {
            return _auditRepo.GetAll()
                .OrderByDescending(a => a.Timestamp)
                .Take(500)
                .ToList();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeRepo.GetAll();
        }

        public void DeleteLog(int logId)
        {
            _auditRepo.Delete(logId);
        }

        public void DeleteLogsByPeriod(DateTime from, DateTime to)
        {
            var logsToDelete = _auditRepo.GetAll()
                .Where(a => a.Timestamp >= from && a.Timestamp <= to)
                .ToList();

            foreach (var log in logsToDelete)
            {
                _auditRepo.Delete(log.LogId);
            }
        }

        public void AddLog(AuditLog log)
        {
            if (string.IsNullOrWhiteSpace(log.Action))
            {
                throw new ArgumentException("Action is required");
            }
            if (string.IsNullOrWhiteSpace(log.EntityType))
            {
                throw new ArgumentException("The entity type is required");
            }
            if (string.IsNullOrWhiteSpace(log.Description))
            {
                throw new ArgumentException("The description is required");
            }

            log.Timestamp = DateTime.Now;
            _auditRepo.Add(log);
        }

        public void LogServiceAction(string action, int serviceId, string serviceName, Employee employee, string details = null)
        {
            var description = $"{action} service '{serviceName}'";
            if (!string.IsNullOrEmpty(details)) description += $": {details}";

            var log = new AuditLog
            {
                EmployeeId = employee?.EmployeeId,
                Action = action,
                EntityType = "Service",
                EntityId = serviceId,
                Description = description,
                Timestamp = DateTime.Now
            };
            _auditRepo.Add(log);
        }

        public void LogServiceCheck(int serviceId, string serviceName, string status, int? responseTime)
        {
            var description = $"Automatic service check '{serviceName}': {status}";
            if (responseTime.HasValue) description += $" ({responseTime} ms)";

            var log = new AuditLog
            {
                EmployeeId = null,
                Action = "Service Check",
                EntityType = "Service",
                EntityId = serviceId,
                Description = description,
                Timestamp = DateTime.Now
            };
            _auditRepo.Add(log);
        }

        public void LogIncidentAction(string action, int incidentId, string incidentTitle, Employee employee, string details = null)
        {
            var description = $"{action} incident '{incidentTitle}'";
            if (!string.IsNullOrEmpty(details)) description += $". {details}";

            var log = new AuditLog
            {
                EmployeeId = employee?.EmployeeId,
                Action = action,
                EntityType = "Incident",
                EntityId = incidentId,
                Description = description,
                Timestamp = DateTime.Now
            };
            _auditRepo.Add(log);
        }

        public IEnumerable<AuditLog> GetLogsByAction(string action)
        {
            return _auditRepo.GetAll()
                .Where(a => a.Action == action)
                .OrderByDescending(a => a.Timestamp)
                .Take(200)
                .ToList();
        }

        public IEnumerable<AuditLog> GetLogsByEmployee(int employeeId)
        {
            return _auditRepo.GetAll()
                .Where(a => a.EmployeeId == employeeId)
                .OrderByDescending(a => a.Timestamp)
                .Take(200)
                .ToList();
        }

        public IEnumerable<AuditLog> GetLogsByDateRange(DateTime from, DateTime to)
        {
            return _auditRepo.GetAll()
                .Where(a => a.Timestamp >= from && a.Timestamp <= to)
                .OrderByDescending(a => a.Timestamp)
                .ToList();
        }
    }
}

