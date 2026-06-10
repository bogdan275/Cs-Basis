using System;
using System.Collections.Generic;
using System.Text;
using Data.Context;
using Data.Models;
using Repositories.Reporitories;

namespace Repositories.ForModels
{
    public class ReturnPolicyRepository : Repository<Return_Policy>
    {
        public ReturnPolicyRepository(PharmacyContext context) : base(context)
        {
        }
    }
}
