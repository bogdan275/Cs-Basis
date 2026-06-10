using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ServiceId { get; set; }

        [Required]
        [MaxLength(200)]
        public string ServiceName { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }

        public int CategoryId { get; set; }
        public virtual ServiceCategory Category { get; set; }

        [Required]
        [MaxLength(50)]
        public string ServiceType { get; set; } // HTTP, TCP, Database, FileSystem, Custom

        [MaxLength(500)]
        public string? Url { get; set; }

        [MaxLength(255)]
        public string? NetworkAddress { get; set; }

        public int? Port { get; set; }

        [Required]
        [MaxLength(50)]
        public string Criticality { get; set; } // Low, Medium, High, Critical

        public int? ResponsibleEmployeeId { get; set; }
        public virtual Employee ResponsibleEmployee { get; set; }

        public bool IsActive { get; set; } = true;

        [Required]
        [MaxLength(50)]
        public string CheckMethod { get; set; } = "HTTP_GET";

        public int CheckInterval { get; set; } = 5; // хвилини

        public int Timeout { get; set; } = 10; // секунди

        public int RetryCount { get; set; } = 3;

        public int? ExpectedStatusCode { get; set; } = 200;

        [MaxLength(500)]
        public string? ExpectedResponseContains { get; set; }

        public int WarningResponseTime { get; set; } = 3000; // мілісекунди

        public int CriticalResponseTime { get; set; } = 10000; // мілісекунди

        public int MaxConsecutiveFailures { get; set; } = 3;

        [Column(TypeName = "decimal(5,2)")]
        public decimal MinUptimePercent { get; set; } = 99.5m;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<ServiceDependency> Dependencies { get; set; } = new List<ServiceDependency>();
        public virtual ICollection<ServiceDependency> DependentServices { get; set; } = new List<ServiceDependency>();
        public virtual ICollection<Trigger> Triggers { get; set; } = new List<Trigger>();
        public virtual ICollection<MonitoringCheck> MonitoringChecks { get; set; } = new List<MonitoringCheck>();
        public virtual ICollection<Incident> Incidents { get; set; } = new List<Incident>();
        public virtual ICollection<MaintenanceWindow> MaintenanceWindows { get; set; } = new List<MaintenanceWindow>();

        public override string ToString()
        {
            return $"{ServiceName} ({Criticality})";
        }
    }
}
