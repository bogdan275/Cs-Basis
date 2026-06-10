using Data;
using Data.Models;
using Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Main
{
    public class ServiceCategoryRepository : Repository<ServiceCategory>
    {
        public ServiceCategoryRepository(MonitoringContext context) : base(context) { }
    }
}
