using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Position { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        public int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public int? SpecializationId { get; set; }
        public virtual Specialization Specialization { get; set; }

        public virtual ICollection<Service> ResponsibleServices { get; set; } = new List<Service>();
        public virtual ICollection<Incident> AssignedIncidents { get; set; } = new List<Incident>();
        public virtual ICollection<MaintenanceWindow> ScheduledMaintenances { get; set; } = new List<MaintenanceWindow>();
        public virtual ICollection<IncidentComment> Comments { get; set; } = new List<IncidentComment>();

        public override string ToString()
        {
            return $"{FullName} - {Position}";
        }
    }
}
