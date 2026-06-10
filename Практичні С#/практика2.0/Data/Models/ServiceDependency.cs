using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class ServiceDependency
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DependencyId { get; set; }

        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }

        public int DependsOnServiceId { get; set; }
        public virtual Service DependsOnService { get; set; }

        [Required]
        [MaxLength(50)]
        public string DependencyType { get; set; } // Required, Optional, Performance

        [MaxLength(500)]
        public string? Description { get; set; }

        public override string ToString()
        {
            return $"{Service?.ServiceName} depends on {DependsOnService?.ServiceName} ({DependencyType})";
        }
    }
}
