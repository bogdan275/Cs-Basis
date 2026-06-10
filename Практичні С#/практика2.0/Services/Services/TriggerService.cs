using Data.Models;
using Repositories.Base;
using Repositories.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class TriggerService
    {
        private readonly TriggerRepository _triggerRepo;
        private readonly ServiceRepository _serviceRepo;
        private readonly IncidentSeverityRepository _severityRepo;

        public TriggerService(
            TriggerRepository triggerRepo,
            ServiceRepository serviceRepo,
            IncidentSeverityRepository severityRepo)
        {
            _triggerRepo = triggerRepo;
            _serviceRepo = serviceRepo;
            _severityRepo = severityRepo;
        }

        public IEnumerable<Trigger> GetAllTriggers()
        {
            return _triggerRepo.GetAll();
        }

        public IEnumerable<Trigger> GetTriggersForService(int serviceId)
        {
            return _triggerRepo.GetActiveTriggersForService(serviceId);
        }

        public IEnumerable<Service> GetAllServices()
        {
            return _serviceRepo.GetAll();
        }

        public IEnumerable<IncidentSeverity> GetAllSeverities()
        {
            return _severityRepo.GetAll();
        }

        public void AddTrigger(Trigger trigger)
        {
            ValidateTrigger(trigger);

            trigger.CreatedAt = DateTime.Now;
            _triggerRepo.Add(trigger);
        }

        public void UpdateTrigger(Trigger trigger)
        {
            ValidateTrigger(trigger);

            _triggerRepo.Update(trigger);
        }

        public void DeleteTrigger(int id)
        {
            _triggerRepo.Delete(id);
        }

        public void EnableTrigger(int id)
        {
            var trigger = _triggerRepo.GetById(id);
            if (trigger == null)
            {
                throw new ArgumentException("Trigger not found");
            }

            trigger.IsEnabled = true;
            _triggerRepo.Update(trigger);
        }

        public void DisableTrigger(int id)
        {
            var trigger = _triggerRepo.GetById(id);
            if (trigger == null)
            {
                throw new ArgumentException("Trigger not found");
            }

            trigger.IsEnabled = false;
            _triggerRepo.Update(trigger);
        }

        private void ValidateTrigger(Trigger trigger)
        {
            if (string.IsNullOrWhiteSpace(trigger.TriggerName))
            {
                throw new ArgumentException("Trigger name can't be null");
            }

            if (string.IsNullOrWhiteSpace(trigger.TriggerType))
            {
                throw new ArgumentException("Select trigger type");
            }

            if (trigger.ConsecutiveChecks <= 0)
            {
                throw new ArgumentException("The number of consecutive checks must be greater than 0");
            }
        }
    }
}
