using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Base;

namespace Repositories.Main
{
    public class StorageBinRepo : Repository<StorageBin>
    {
        public StorageBinRepo(FinalProjectContext context) : base(context)
        {
        }
        public override IEnumerable<StorageBin> GetAll()
        {
            return _dbSet
                .Include(b => b.StorageZone)
                .ThenInclude(z => z.Warehouse)
                .ToList();
        }
    }
}
