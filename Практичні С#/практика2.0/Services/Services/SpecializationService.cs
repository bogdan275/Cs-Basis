using Data.Models;
using Repositories.Base;
using Repositories.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class SpecializationService
    {
        private readonly SpecializationRepository _repository;

        public SpecializationService(SpecializationRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Specialization> GetAllSpecializations()
        {
            return _repository.GetAll();
        }

        public void AddSpecialization(string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Specialization name can't be null");
            }

            var specialization = new Specialization
            {
                SpecializationName = name.Trim(),
                Description = description?.Trim()
            };

            _repository.Add(specialization);
        }

        public void UpdateSpecialization(Specialization specialization, string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Specialization name can't be null");
            }

            specialization.SpecializationName = name.Trim();
            specialization.Description = description?.Trim();

            _repository.Update(specialization);
        }

        public void DeleteSpecialization(int id)
        {
            _repository.Delete(id);
        }
    }
}
