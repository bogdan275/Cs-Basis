using System;
using System.Collections.Generic;
using System.Text;
using Data.Context;
using Data.Models;
using Repositories.Reporitories;

namespace Repositories.ForModels
{
    public class RecipeRepository : Repository<Recipe>
    {
        public RecipeRepository(PharmacyContext context) : base(context)
        {
        }
    }
}
