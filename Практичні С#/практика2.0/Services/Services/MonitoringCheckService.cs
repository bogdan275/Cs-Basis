using Data.Models;
using Repositories.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class MonitoringCheckService
    {
        private readonly MonitoringCheckRepository _checkRepo;
        private readonly ServiceRepository _serviceRepo;

        public MonitoringCheckService(
            MonitoringCheckRepository checkRepo,
            ServiceRepository serviceRepo)
        {
            _checkRepo = checkRepo;
            _serviceRepo = serviceRepo;
        }

        public IEnumerable<MonitoringCheck> GetAllChecks()
        {
            return _checkRepo.GetAll();
        }

        public IEnumerable<Service> GetAllServices()
        {
            return _serviceRepo.GetAll();
        }

        public IEnumerable<MonitoringCheck> GetChecksByService(int serviceId, int count = 100)
        {
            return _checkRepo.GetByService(serviceId, count);
        }

        public IEnumerable<MonitoringCheck> GetChecksByDateRange(int serviceId, DateTime from, DateTime to)
        {
            return _checkRepo.GetByDateRange(serviceId, from, to);
        }

        public void AddCheck(MonitoringCheck check)
        {
            if (string.IsNullOrWhiteSpace(check.Status))
            {
                throw new ArgumentException("Check status required");
            }

            _checkRepo.Add(check);
        }

        public decimal CalculateUptime(int serviceId, DateTime from, DateTime to)
        {
            var checks = _checkRepo.GetByDateRange(serviceId, from, to);

            if (!checks.Any())
                return 0;

            var totalChecks = checks.Count();
            var successfulChecks = checks.Count(c => c.Status == "Success");

            return (decimal)successfulChecks / totalChecks * 100;
        }

        public int? GetAverageResponseTime(int serviceId, DateTime from, DateTime to)
        {
            var checks = _checkRepo.GetByDateRange(serviceId, from, to)
                .Where(c => c.ResponseTime.HasValue)
                .ToList();

            if (!checks.Any())
                return null;

            return (int)checks.Average(c => c.ResponseTime.Value);
        }

        public IEnumerable<MonitoringCheck> GetRecentFailures(int serviceId)
        {
            return _checkRepo.GetFailedChecks(serviceId);
        }

        public void DeleteCheck(int checkId)
        {
            _checkRepo.Delete(checkId);
        }
    }
}
