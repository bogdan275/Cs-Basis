using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.Models;
using Repositories.Base;

namespace Repositories.Main
{
    public class BillingRecordRepo : Repository<BillingRecord>
    {
        public BillingRecordRepo(FinalProjectContext context) : base(context)
        {
        }
    }
}
