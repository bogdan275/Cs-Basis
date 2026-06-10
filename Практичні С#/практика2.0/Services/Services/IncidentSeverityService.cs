using Data.Models;
using Repositories.Base;
using Repositories.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class IncidentSeverityService
    {
        private readonly IncidentSeverityRepository _repository;

        public IncidentSeverityService(IncidentSeverityRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<IncidentSeverity> GetAllSeverities()
        {
            return _repository.GetAll();
        }

        public void AddSeverity(string name, string description, int expectedResolutionMinutes, bool notifyManagement)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Incident severity name can't be null");
            }

            if (expectedResolutionMinutes <= 0)
            {
                throw new ArgumentException("The expected resolution time must be greater than 0");
            }

            var severity = new IncidentSeverity
            {
                SeverityName = name.Trim(),
                Description = description?.Trim(),
                ExpectedResolutionTimeMinutes = expectedResolutionMinutes,
                NotifyManagement = notifyManagement
            };

            _repository.Add(severity);
        }

        public void UpdateSeverity(IncidentSeverity severity, string name, string description,
            int expectedResolutionMinutes, bool notifyManagement)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Incident severity name can't be null");
            }

            if (expectedResolutionMinutes <= 0)
            {
                throw new ArgumentException("The expected resolution time must be greater than 0");
            }

            severity.SeverityName = name.Trim();
            severity.Description = description?.Trim();
            severity.ExpectedResolutionTimeMinutes = expectedResolutionMinutes;
            severity.NotifyManagement = notifyManagement;

            _repository.Update(severity);
        }

        public void DeleteSeverity(int id)
        {
            _repository.Delete(id);
        }
    }
}
