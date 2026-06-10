using System;
using System.Collections.Generic;
using System.Text;
using Data.Context;
using Data.Models;
using Repositories.Reporitories;

namespace Repositories.ForModels
{
    public class SaleRepository : Repository<Sale>
    {
        public SaleRepository(PharmacyContext context) : base(context)
        {
        }
    }
}
