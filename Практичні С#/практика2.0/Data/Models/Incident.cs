using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Incident
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IncidentId { get; set; }

        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }

        public int SeverityId { get; set; }
        public virtual IncidentSeverity Severity { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; } // New, Assigned, InProgress, Resolved, Closed

        [Required]
        [MaxLength(50)]
        public string Priority { get; set; } // Low, Medium, High, Critical

        [Required]
        public DateTime DetectedAt { get; set; }

        public int? AssignedToEmployeeId { get; set; }
        public virtual Employee AssignedToEmployee { get; set; }

        public DateTime? ResolvedAt { get; set; }

        public DateTime? ClosedAt { get; set; }

        public int? DowntimeMinutes { get; set; }

        [MaxLength(1000)]
        public string? RootCause { get; set; }

        [MaxLength(2000)]
        public string? Solution { get; set; }

        [MaxLength(1000)]
        public string? Recommendations { get; set; }

        public int? TriggeredByTriggerId { get; set; }

        // Навігаційні властивості
        public virtual Trigger TriggeredByTrigger { get; set; }
        public virtual ICollection<IncidentComment> Comments { get; set; } = new List<IncidentComment>();

        [NotMapped]
        public int? ResolutionTimeMinutes
        {
            get
            {
                if (ResolvedAt.HasValue)
                {
                    return (int)(ResolvedAt.Value - DetectedAt).TotalMinutes;
                }
                return null;
            }
        }

        public override string ToString()
        {
            return $"[{Status}] {Title} - {Service?.ServiceName}";
        }
    }
}
