using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class BillingRecord
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public DateTime BillingDate { get; set; }
        [Required]
        public DateTime PeriodStart { get; set; }
        [Required]
        public DateTime PeriodEnd { get; set; }
        [Required]

        public decimal TotalAmount { get; set; }
        public string Description { get; set; } 

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        public override string ToString()
        {
            return $"Billing {Id}";
        }
    }
}
