using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace Data.Models
{
    public class AuditLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LogId { get; set; }

        public int? EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        [Required]
        [MaxLength(100)]
        public string Action { get; set; }
        // Тільки: "ServiceCheck", "IncidentCreated", "IncidentResolved", 
        //         "ServiceCreated", "ServiceUpdated", "ServiceDeleted",
        //         "MaintenanceScheduled"

        [Required]
        [MaxLength(100)]
        public string EntityType { get; set; }
        // Тільки: "Service", "Incident", "MaintenanceWindow"

        public int? EntityId { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public DateTime Timestamp { get; set; } = DateTime.Now;

        public override string ToString()
        {
            string user = Employee != null ? Employee.FullName : "System";
            return $"{Timestamp:yyyy-MM-dd HH:mm:ss} - {user} - {Description}";
        }
    }
}
