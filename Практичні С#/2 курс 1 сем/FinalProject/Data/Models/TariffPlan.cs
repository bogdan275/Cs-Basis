using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class TariffPlan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } 
        [Required]
        public decimal DailyStorageCostPerCubicMeter { get; set; }

        public decimal HandlingFeePerUnit { get; set; }

        public virtual ICollection<Client> Clients { get; set; }

        public override string ToString()
        {
            return $"{Name} ({DailyStorageCostPerCubicMeter}$)";
        }
    
    }
}
