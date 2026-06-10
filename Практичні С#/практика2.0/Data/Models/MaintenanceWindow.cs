using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class MaintenanceWindow
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaintenanceId { get; set; }

        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }

        public int ScheduledByEmployeeId { get; set; }
        public virtual Employee ScheduledByEmployee { get; set; }

        [Required]
        public DateTime StartDateTime { get; set; }

        [Required]
        public DateTime EndDateTime { get; set; }

        public DateTime? ActualStartDateTime { get; set; }

        public DateTime? ActualEndDateTime { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; } // Scheduled, InProgress, Completed, Cancelled

        [Required]
        [MaxLength(100)]
        public string Reason { get; set; } // Update, Hardware Replacement, Configuration Change, Security Patch

        [MaxLength(1000)]
        public string? ImpactDescription { get; set; }

        public bool NotifyUsers { get; set; } = true;

        public override string ToString()
        {
            return $"{Title} - {Service?.ServiceName} ({StartDateTime:yyyy-MM-dd HH:mm})";
        }
    }
}
