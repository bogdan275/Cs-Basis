using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class MonitoringCheck
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CheckId { get; set; }

        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }

        [Required]
        public DateTime CheckDateTime { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; } // Success, Warning, Error, Timeout

        public int? ResponseTime { get; set; } // В мілісекундах

        public int? StatusCode { get; set; }

        [MaxLength(1000)]
        public string? ErrorMessage { get; set; }

        [MaxLength(2000)]
        public string? Details { get; set; }

        public override string ToString()
        {
            return $"{Service?.ServiceName} - {CheckDateTime:yyyy-MM-dd HH:mm:ss} [{Status}]";
        }
    }
}
