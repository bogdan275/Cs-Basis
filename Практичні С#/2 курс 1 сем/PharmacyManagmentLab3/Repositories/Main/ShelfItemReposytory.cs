using System;
using System.Collections.Generic;
using System.Text;
using Data.Context;
using Data.Models;
using Repositories.Reporitories;

namespace Repositories.ForModels
{
    public class ShelfItemReposytory : Repository<Shelf_Item>
    {
        public ShelfItemReposytory(PharmacyContext context) : base(context)
        {
        }
    }
}
