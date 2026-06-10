using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.Models;
using Repositories.Base;

namespace Repositories.Main
{
    public class InboundOrderRepo : Repository<InboundOrder>
    {
        public InboundOrderRepo(FinalProjectContext context) : base(context)
        {
        }
    }
}
