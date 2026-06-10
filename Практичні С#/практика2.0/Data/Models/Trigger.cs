using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Trigger
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TriggerId { get; set; }

        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }

        [Required]
        [MaxLength(200)]
        public string TriggerName { get; set; } // "High Response Time", "Service Unavailable"

        [Required]
        [MaxLength(50)]
        public string TriggerType { get; set; }

        [MaxLength(200)]
        public string Condition { get; set; }

        public int? ThresholdValue { get; set; }

        public int ConsecutiveChecks { get; set; } = 1;

        public int IncidentSeverityId { get; set; }
        public virtual IncidentSeverity IncidentSeverity { get; set; }

        [Required]
        [MaxLength(50)]
        public string IncidentPriority { get; set; } // Low, Medium, High, Critical

        public bool IsEnabled { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? LastTriggeredAt { get; set; }

        public virtual ICollection<Incident> TriggeredIncidents { get; set; } = new List<Incident>();

        public override string ToString()
        {
            return $"{TriggerName} - {Service?.ServiceName} [{(IsEnabled ? "Enabled" : "Disabled")}]";
        }
    }
}
