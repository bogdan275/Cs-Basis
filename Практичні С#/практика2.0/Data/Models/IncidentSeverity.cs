using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class IncidentSeverity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SeverityId { get; set; }

        [Required]
        [MaxLength(50)]
        public string SeverityName { get; set; } // Minor, Moderate, Major, Critical
        [MaxLength(500)]

        public string? Description { get; set; }
        public int ExpectedResolutionTimeMinutes { get; set; }
        public bool NotifyManagement { get; set; }

        public virtual ICollection<Incident> Incidents { get; set; } = new List<Incident>();
        public virtual ICollection<Trigger> Triggers { get; set; } = new HashSet<Trigger>();

        public override string ToString()
        {
            return $"{SeverityName} (SLA: {ExpectedResolutionTimeMinutes} min)";
        }
    }
}
