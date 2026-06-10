using System;
using System.Collections.Generic;
using System.Text;
using Data.Context;
using Data.Models;
using Repositories.Reporitories;

namespace Repositories.ForModels
{
    public class PurchaseOrderItemRepository : Repository<Purchase_Order_Item>
    {
        public PurchaseOrderItemRepository(PharmacyContext context) : base(context)
        {
        }
    }
}
