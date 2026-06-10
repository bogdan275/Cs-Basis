using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Repositories.Base;

namespace Repositories.Main
{
    public class InventoryItemRepo : Repository<InventoryItem>
    {
        public InventoryItemRepo(FinalProjectContext context) : base(context)
        {

        }

        public override IEnumerable<InventoryItem> GetAll()
        {
            return _dbSet
                .Include(x => x.Product)    
                .Include(x => x.StorageBin) 
                .ToList();
        }
    }
}
