using System;
using System.Collections.Generic;
using Data.Models;
using Repositories.Reporitories;

namespace Services
{
    public class RefrigeratorLogService
    {
        private readonly IRepository<Refrigerator_Log> _logRepo;
        private readonly IRepository<Refrigerator> _fridgeRepo;

        public RefrigeratorLogService(
            IRepository<Refrigerator_Log> logRepo,
            IRepository<Refrigerator> fridgeRepo)
        {
            _logRepo = logRepo;
            _fridgeRepo = fridgeRepo;
        }

        public IEnumerable<Refrigerator_Log> GetAllLogs()
        {
            return _logRepo.GetAll();
        }
        public IEnumerable<Refrigerator> GetAllRefrigerators()
        {
            return _fridgeRepo.GetAll();
        }

        public void AddLog(Refrigerator_Log log)
        {
            if (log.Refrigerator == null)
            {
                throw new ArgumentException("Please select a refrigerator.");
            }

            if (log.Min_Temp > log.Max_Temp)
            {
                throw new ArgumentException("Minimum temperature cannot be higher than Maximum temperature.");
            }

            _logRepo.Add(log);
        }

        public void UpdateLog(Refrigerator_Log log)
        {
            if (log.Min_Temp > log.Max_Temp)
            {
                throw new ArgumentException("Minimum temperature cannot be higher than Maximum temperature.");
            }

            _logRepo.Update(log);
        }

        public void DeleteLog(int id)
        {
            _logRepo.Delete(id);
        }
    }
}