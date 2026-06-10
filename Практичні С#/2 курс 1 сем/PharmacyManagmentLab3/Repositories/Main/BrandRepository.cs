using System;
using System.Collections.Generic;
using System.Text;
using Data.Context;
using Data.Models;
using Repositories.Extentions;
using Repositories.Reporitories;

namespace Repositories.ForModels
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        public BrandRepository(PharmacyContext context) : base(context)
        {
        }
    }
}
