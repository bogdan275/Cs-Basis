using Data.Models;
using Repositories.Base;
using Repositories.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class MaintenanceWindowService
    {
        private readonly MaintenanceWindowRepository _maintenanceRepo;
        private readonly ServiceRepository _serviceRepo;
        private readonly EmployeeRepository _employeeRepo;

        public MaintenanceWindowService(
            MaintenanceWindowRepository maintenanceRepo,
            ServiceRepository serviceRepo,
            EmployeeRepository employeeRepo)
        {
            _maintenanceRepo = maintenanceRepo;
            _serviceRepo = serviceRepo;
            _employeeRepo = employeeRepo;
        }

        public IEnumerable<MaintenanceWindow> GetAllMaintenanceWindows()
        {
            return _maintenanceRepo.GetAll();
        }

        public IEnumerable<Service> GetAllServices()
        {
            return _serviceRepo.GetAll();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeRepo.GetAll();
        }

        public void AddMaintenanceWindow(MaintenanceWindow maintenance)
        {
            ValidateMaintenanceWindow(maintenance);
            _maintenanceRepo.Add(maintenance);
        }

        public void UpdateMaintenanceWindow(MaintenanceWindow maintenance)
        {
            ValidateMaintenanceWindow(maintenance);
            _maintenanceRepo.Update(maintenance);
        }

        public void DeleteMaintenanceWindow(int maintenanceId)
        {
            _maintenanceRepo.Delete(maintenanceId);
        }

        private void ValidateMaintenanceWindow(MaintenanceWindow maintenance)
        {
            if (string.IsNullOrWhiteSpace(maintenance.Title))
            {
                throw new ArgumentException("Maintenance window name is required");
            }

            if (maintenance.StartDateTime >= maintenance.EndDateTime)
            {
                throw new ArgumentException("The start time must be earlier than the end time");
            }

            if (maintenance.StartDateTime < DateTime.Now && maintenance.Status == "Scheduled")
            {
                throw new ArgumentException("You cannot schedule maintenance in the past");
            }
        }

        public bool IsServiceInMaintenance(int serviceId)
        {
            return _maintenanceRepo.IsInMaintenanceWindow(serviceId, DateTime.Now);
        }

        public IEnumerable<MaintenanceWindow> GetScheduledMaintenances()
        {
            return _maintenanceRepo.GetScheduledMaintenances();
        }

        public void StartMaintenance(int maintenanceId)
        {
            var maintenance = _maintenanceRepo.GetById(maintenanceId);

            if (maintenance == null)
            {
                throw new ArgumentException("Maintenance window not found");
            }

            if (maintenance.Status != "Scheduled")
            {
                throw new InvalidOperationException("Only scheduled maintenance can be started");
            }

            maintenance.Status = "InProgress";
            maintenance.ActualStartDateTime = DateTime.Now;
            _maintenanceRepo.Update(maintenance);
        }

        public void CompleteMaintenance(int maintenanceId)
        {
            var maintenance = _maintenanceRepo.GetById(maintenanceId);

            if (maintenance == null)
                throw new ArgumentException("Maintenance window not found");

            if (maintenance.Status != "InProgress")
                throw new InvalidOperationException("Only maintenance in progress can be completed");

            maintenance.Status = "Completed";
            maintenance.ActualEndDateTime = DateTime.Now;
            _maintenanceRepo.Update(maintenance);
        }

        public void CancelMaintenance(int maintenanceId)
        {
            var maintenance = _maintenanceRepo.GetById(maintenanceId);

            if (maintenance == null)
                throw new ArgumentException("Maintenance window not found");

            if (maintenance.Status == "Completed")
                throw new InvalidOperationException("Completed services cannot be canceled");

            maintenance.Status = "Cancelled";
            _maintenanceRepo.Update(maintenance);
        }
    }
}
