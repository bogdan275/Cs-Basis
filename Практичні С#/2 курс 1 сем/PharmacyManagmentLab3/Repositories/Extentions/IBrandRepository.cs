using System;
using System.Collections.Generic;
using System.Text;
using Data.Models;
using Repositories.Reporitories;

namespace Repositories.Extentions
{
    public interface IBrandRepository : IRepository<Brand>
    {
        // Тут пізніше можна додати метод: Brand GetByName(string name);
    }
}
