using System;
using System.Collections.Generic;
using System.Text;
using Data.Context;
using Data.Models;
using Repositories.Extentions;
using Repositories.Reporitories;

namespace Repositories.ForModels
{
    public class BatchRepository : Repository<Batch>, IBatchRepository
    {
        public BatchRepository(PharmacyContext context) : base(context)
        {
        }
    }
}
