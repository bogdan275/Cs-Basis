using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Base;

namespace Repositories.Main
{
    public class ProductRepo : Repository<Product>
    {
        public ProductRepo(FinalProjectContext context) : base(context)
        {
        }

        public override IEnumerable<Product> GetAll()
        {
            return _dbSet
                .Include(x => x.Client) 
                .ToList();
        }
    }
}
