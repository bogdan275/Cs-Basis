using Data;
using Data.Models;
using Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Main
{
    public class IncidentSeverityRepository : Repository<IncidentSeverity>
    {
        public IncidentSeverityRepository(MonitoringContext context) : base(context) { }
    }
}
