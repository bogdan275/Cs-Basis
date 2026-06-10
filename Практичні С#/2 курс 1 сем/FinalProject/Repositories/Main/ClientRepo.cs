using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Base;

namespace Repositories.Main
{
    public class ClientRepo : Repository<Client>
    {
        public ClientRepo(FinalProjectContext context) : base(context)
        {
        }

        public override IEnumerable<Client> GetAll()
        {
            return _dbSet.Include(c => c.TariffPlan).ToList();
        }
    }
}
