using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.Models;
using Repositories.Base;

namespace Repositories.Main
{
    public class TariffPlanRepo : Repository<TariffPlan>
    {
        public TariffPlanRepo(FinalProjectContext context) : base(context)
        {
        }
    }
}
