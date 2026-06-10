using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Base;

namespace Repositories.Main
{
    public class StorageZoneRepo : Repository<StorageZone>
    {
        public StorageZoneRepo(FinalProjectContext context) : base(context)
        {
        }
        public override IEnumerable<StorageZone> GetAll()
        {
            return _dbSet.Include(z => z.Warehouse).ToList();
        }
    }
}
