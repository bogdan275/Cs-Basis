using System;
using System.Collections.Generic;
using System.Text;
using Data.Context;
using Data.Models;
using Repositories.Reporitories;

namespace Repositories.ForModels
{
    public class PurchaseOrderRepository : Repository<Purchase_Order>
    {
        public PurchaseOrderRepository(PharmacyContext context) : base(context)
        {
        }
    }
}
