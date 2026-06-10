using Data.Models;
using Repositories.Base;
using Repositories.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class IncidentService
    {
        private readonly IncidentRepository _incidentRepo;
        private readonly ServiceRepository _serviceRepo;
        private readonly IncidentSeverityRepository _severityRepo;
        private readonly EmployeeRepository _employeeRepo;
        private readonly AuditLogRepository _auditLogRepo;

        public IncidentService(
            IncidentRepository incidentRepo,
            ServiceRepository serviceRepo,
            IncidentSeverityRepository severityRepo,
            EmployeeRepository employeeRepo,
            AuditLogRepository auditLogRepo)
        {
            _incidentRepo = incidentRepo;
            _serviceRepo = serviceRepo;
            _severityRepo = severityRepo;
            _employeeRepo = employeeRepo;
            _auditLogRepo = auditLogRepo;
        }

        public IEnumerable<Incident> GetAllIncidents()
        {
            return _incidentRepo.GetAll();
        }

        public IEnumerable<Incident> GetActiveIncidents()
        {
            return _incidentRepo.GetActiveIncidents();
        }

        public IEnumerable<Incident> GetByStatus(string status)
        {
            return _incidentRepo.GetByStatus(status);
        }

        public IEnumerable<Incident> GetByService(int serviceId)
        {
            return _incidentRepo.GetByService(serviceId);
        }

        public Incident GetById(int id)
        {
            return _incidentRepo.GetById(id);
        }

        public IEnumerable<Service> GetAllServices()
        {
            return _serviceRepo.GetAll();
        }

        public IEnumerable<IncidentSeverity> GetAllSeverities()
        {
            return _severityRepo.GetAll();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeRepo.GetAll();
        }

        public void AddIncident(Incident incident, Employee currentUser)
        {
            ValidateIncident(incident);

            incident.DetectedAt = DateTime.Now;
            incident.Status = "New";

            _incidentRepo.Add(incident);

            var auditLog = new AuditLog
            {
                EmployeeId = currentUser?.EmployeeId,
                Action = "Incident Created",
                EntityType = "Incident",
                EntityId = incident.IncidentId,
                Description = $"Incident was created  '{incident.Title}' for service '{incident.Service?.ServiceName}'",
                Timestamp = DateTime.Now
            };
            _auditLogRepo.Add(auditLog);
        }

        public void UpdateIncident(Incident incident, Employee currentUser)
        {
            ValidateIncident(incident);
            _incidentRepo.Update(incident);
            var auditLog = new AuditLog
            {
                EmployeeId = currentUser?.EmployeeId,
                Action = "Incident Updated",
                EntityType = "Incident",
                EntityId = incident.IncidentId,
                Description = $"Incident was updated '{incident.Title}'",
                Timestamp = DateTime.Now
            };
            _auditLogRepo.Add(auditLog);
        }

        public void AssignIncident(Incident incident, Employee assignee, Employee currentUser)
        {
            incident.AssignedToEmployeeId = assignee.EmployeeId;
            incident.Status = "InProgress";

            _incidentRepo.Update(incident);

            var auditLog = new AuditLog
            {
                EmployeeId = currentUser?.EmployeeId,
                Action = "Incident Assigned",
                EntityType = "Incident",
                EntityId = incident.IncidentId,
                Description = $"Incident '{incident.Title}', responsible person:{assignee.FullName}",
                Timestamp = DateTime.Now
            };
            _auditLogRepo.Add(auditLog);
        }

        public void ResolveIncident(Incident incident, string rootCause, string solution,
            string recommendations, Employee resolver)
        {
            if (string.IsNullOrWhiteSpace(rootCause))
            {
                throw new ArgumentException("Write down an incident cause");
            }

            if (string.IsNullOrWhiteSpace(solution))
            {
                throw new ArgumentException("Write down the solution");
            }

            incident.Status = "Resolved";
            incident.RootCause = rootCause.Trim();
            incident.Solution = solution.Trim();
            incident.Recommendations = recommendations?.Trim();
            incident.ResolvedAt = DateTime.Now;

            if (incident.DowntimeMinutes.HasValue)
            {

            }
            else
            {
                incident.DowntimeMinutes = (int)(DateTime.Now - incident.DetectedAt).TotalMinutes;
            }

            _incidentRepo.Update(incident);

            var auditLog = new AuditLog
            {
                EmployeeId = resolver?.EmployeeId,
                Action = "Incident Resolved",
                EntityType = "Incident",
                EntityId = incident.IncidentId,
                Description = $"Incident was resolved '{incident.Title}', solution: {solution.Substring(0, Math.Min(100, solution.Length))}...",
                Timestamp = DateTime.Now
            };
            _auditLogRepo.Add(auditLog);
        }

        public void CloseIncident(Incident incident, Employee currentUser)
        {
            if (incident.Status != "Resolved")
            {
                throw new InvalidOperationException("You can close only resoloved incidents");
            }

            incident.Status = "Closed";
            incident.ClosedAt = DateTime.Now;

            _incidentRepo.Update(incident);

            var auditLog = new AuditLog
            {
                EmployeeId = currentUser?.EmployeeId,
                Action = "Incident Closed",
                EntityType = "Incident",
                EntityId = incident.IncidentId,
                Description = $"Incident '{incident.Title}' vas closed",
                Timestamp = DateTime.Now
            };
            _auditLogRepo.Add(auditLog);
        }

        public void DeleteIncident(int id, Employee currentUser)
        {
            var incident = _incidentRepo.GetById(id);
            if (incident == null)
            {
                throw new ArgumentException("Incident not found");
            }

            _incidentRepo.Delete(id);

            var auditLog = new AuditLog
            {
                EmployeeId = currentUser?.EmployeeId,
                Action = "Incident Deleted",
                EntityType = "Incident",
                EntityId = id,
                Description = $"Incident '{incident.Title}' was deleted",
                Timestamp = DateTime.Now
            };
            _auditLogRepo.Add(auditLog);
        }

        private void ValidateIncident(Incident incident)
        {
            if (string.IsNullOrWhiteSpace(incident.Title))
            {
                throw new ArgumentException("Incident title can't be null");
            }

            if (string.IsNullOrWhiteSpace(incident.Description))
            {
                throw new ArgumentException("Incident Description can't be null");
            }
        }
    }
}
