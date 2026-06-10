using System;
using System.Collections.Generic;
using System.Text;
using Data.Context;
using Data.Models;
using Repositories.Reporitories;

namespace Repositories.ForModels
{
    public class ActiveIngredientRepository : Repository<Active_Ingredient>
    {
        public ActiveIngredientRepository(PharmacyContext context) : base(context)
        {
        }
    }
}
