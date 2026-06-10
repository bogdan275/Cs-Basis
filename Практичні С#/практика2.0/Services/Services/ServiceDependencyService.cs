using Data.Models;
using Repositories.Base;
using Repositories.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class ServiceDependencyService
    {
        private readonly ServiceDependencyRepository _dependencyRepo;
        private readonly ServiceRepository _serviceRepo;

        public ServiceDependencyService(
            ServiceDependencyRepository dependencyRepo,
            ServiceRepository serviceRepo)
        {
            _dependencyRepo = dependencyRepo;
            _serviceRepo = serviceRepo;
        }

        public IEnumerable<ServiceDependency> GetAllDependencies()
        {
            return _dependencyRepo.GetAll();
        }

        public IEnumerable<Service> GetAllServices()
        {
            return _serviceRepo.GetAll();
        }

        public void AddDependency(ServiceDependency dependency)
        {
            if (dependency.ServiceId == dependency.DependsOnServiceId)
            {
                throw new ArgumentException("A service cannot depend on itself");
            }

            var existing = _dependencyRepo.GetAll()
                .FirstOrDefault(d => d.ServiceId == dependency.ServiceId
                                  && d.DependsOnServiceId == dependency.DependsOnServiceId);

            if (existing != null)
            {
                throw new ArgumentException("This dependency already exists");
            }

            _dependencyRepo.Add(dependency);
        }

        public void UpdateDependency(ServiceDependency dependency)
        {
            if (dependency.ServiceId == dependency.DependsOnServiceId)
            {
                throw new ArgumentException("A service cannot depend on itself");
            }

            _dependencyRepo.Update(dependency);
        }

        public void DeleteDependency(int dependencyId)
        {
            _dependencyRepo.Delete(dependencyId);
        }

        public IEnumerable<ServiceDependency> GetDependenciesForService(int serviceId)
        {
            return _dependencyRepo.GetAll()
                .Where(d => d.ServiceId == serviceId)
                .ToList();
        }

        public IEnumerable<ServiceDependency> GetDependentServices(int serviceId)
        {
            return _dependencyRepo.GetAll()
                .Where(d => d.DependsOnServiceId == serviceId)
                .ToList();
        }
    }
}
