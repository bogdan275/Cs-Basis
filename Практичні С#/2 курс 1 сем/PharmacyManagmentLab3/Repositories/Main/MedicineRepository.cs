using System;
using System.Collections.Generic;
using System.Text;
using Data.Context;
using Data.Models;
using Repositories.Reporitories;

namespace Repositories.ForModels
{
    public class MedicineRepository : Repository<Medicine>
    {
        public MedicineRepository(PharmacyContext context) : base(context)
        {
        }
    }
}
