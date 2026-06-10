using System;
using System.Collections.Generic;
using System.Text;
using Data.Context;
using Data.Models;
using Repositories.Reporitories;

namespace Repositories.ForModels
{
    public class RefrigeratorRepository : Repository<Refrigerator>
    {
        public RefrigeratorRepository(PharmacyContext context) : base(context)
        {
        }
    }
}
