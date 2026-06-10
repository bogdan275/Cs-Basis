using System;
using System.Collections.Generic;
using System.Text;
using Data.Context;
using Data.Models;
using Repositories.Reporitories;

namespace Repositories.ForModels
{
    public class ShelfRepository : Repository<Shelf>
    {
        public ShelfRepository(PharmacyContext context) : base(context)
        {
        }
    }
}
