using Data;
using Data.Models;
using Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Main
{
    public class AuditLogRepository : Repository<AuditLog>
    {
        public AuditLogRepository(MonitoringContext context) : base(context) { }
    }
}
