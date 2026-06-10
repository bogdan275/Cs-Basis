using Data.Models;
using Repositories.Base;
using Repositories.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class ServiceService
    {
        private readonly ServiceRepository _serviceRepo;
        private readonly ServiceCategoryRepository _categoryRepo;
        private readonly EmployeeRepository _employeeRepo;
        private readonly AuditLogRepository _auditLogRepo;

        public ServiceService(
            ServiceRepository serviceRepo,
            ServiceCategoryRepository categoryRepo,
            EmployeeRepository employeeRepo,
            AuditLogRepository auditLogRepo)
        {
            _serviceRepo = serviceRepo;
            _categoryRepo = categoryRepo;
            _employeeRepo = employeeRepo;
            _auditLogRepo = auditLogRepo;
        }

        public IEnumerable<Service> GetAllServices()
        {
            return _serviceRepo.GetAll();
        }

        public IEnumerable<Service> GetActiveServices()
        {
            return _serviceRepo.GetActiveServices();
        }

        public IEnumerable<Service> GetCriticalServices()
        {
            return _serviceRepo.GetCriticalServices();
        }

        public IEnumerable<ServiceCategory> GetAllCategories()
        {
            return _categoryRepo.GetAll();
        }

        public IEnumerable<Employee> GetEligibleEmployees(int categoryId)
        {
            return _employeeRepo.GetByServiceCategory(categoryId);
        }

        public void AddService(Service service, Employee currentUser)
        {
            ValidateService(service);

            service.CreatedAt = DateTime.Now;
            _serviceRepo.Add(service);

            LogServiceAction(currentUser, "Service Created", service,
                $"Service was created '{service.ServiceName}' (category: {service.Category?.CategoryName}, criticality: {service.Criticality})");
        }

        public void UpdateService(Service service, Employee currentUser)
        {
            ValidateService(service);

            _serviceRepo.Update(service);

            LogServiceAction(currentUser, "Service Updated", service,
                $"Service was updated '{service.ServiceName}'");
        }

        public void DeleteService(int id, Employee currentUser)
        {
            var service = _serviceRepo.GetById(id);
            if (service == null)
            {
                throw new ArgumentException("Service not found");
            }

            _serviceRepo.Delete(id);

            var auditLog = new AuditLog
            {
                EmployeeId = currentUser?.EmployeeId,
                Action = "Service Deleted",
                EntityType = "Service",
                EntityId = id,
                Description = $"Service '{service.ServiceName}' was delated",
                Timestamp = DateTime.Now
            };
            _auditLogRepo.Add(auditLog);
        }

        private void ValidateService(Service service)
        {
            if (string.IsNullOrWhiteSpace(service.ServiceName))
            {
                throw new ArgumentException("Service name can't be null");
            }

            if (string.IsNullOrWhiteSpace(service.ServiceType))
            {
                throw new ArgumentException("Select service type");
            }

            if (service.CheckInterval <= 0)
            {
                throw new ArgumentException("the check interval must be greater than 0");
            }

            if (service.Timeout <= 0)
            {
                throw new ArgumentException("Timeout must be greater than 0");
            }
        }

        private void LogServiceAction(Employee currentUser, string action, Service service, string description)
        {
            var auditLog = new AuditLog
            {
                EmployeeId = currentUser?.EmployeeId,
                Action = action,
                EntityType = "Service",
                EntityId = service.ServiceId,
                Description = description,
                Timestamp = DateTime.Now
            };
            _auditLogRepo.Add(auditLog);
        }
    }
}
