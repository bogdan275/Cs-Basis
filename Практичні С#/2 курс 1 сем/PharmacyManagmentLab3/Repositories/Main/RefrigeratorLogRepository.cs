using System;
using System.Collections.Generic;
using System.Text;
using Data.Context;
using Data.Models;
using Repositories.Reporitories;

namespace Repositories.ForModels
{
    public class RefrigeratorLogRepository : Repository<Refrigerator_Log>
    {
        public RefrigeratorLogRepository(PharmacyContext context) : base(context)
        {
        }
    }
}
