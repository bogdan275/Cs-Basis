using Data;
using Data.Models;
using Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Main
{
    public class ServiceDependencyRepository : Repository<ServiceDependency>
    {
        public ServiceDependencyRepository(MonitoringContext context) : base(context) { }
    }
}
