using System.Collections.Generic;
using Data.Models;
using Repositories.Main;

namespace Services
{
    public class StockMovementService
    {
        private readonly StockMovementRepo _repo;

        public StockMovementService(StockMovementRepo repo)
        {
            _repo = repo;
        }

        public IEnumerable<StockMovement> GetAll()
        {
            return _repo.GetAll();
        }
    }
}