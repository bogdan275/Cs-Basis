using Data;
using Data.Models;
using Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Main
{
    public class DepartmentRepository : Repository<Department>
    {
        public DepartmentRepository(MonitoringContext context) : base(context) { }
    }
}
