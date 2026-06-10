using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Base;

namespace Repositories.Main
{
    public class StockMovementRepo : Repository<StockMovement>
    {
        public StockMovementRepo(FinalProjectContext context) : base(context)
        {
        }

        public override IEnumerable<StockMovement> GetAll()
        {
            return _dbSet
                .Include(x => x.Product)
                .Include(x => x.FromBin)
                .Include(x => x.ToBin)
                .OrderByDescending(x => x.MovementDate) 
                .ToList();
        }
    }
}
