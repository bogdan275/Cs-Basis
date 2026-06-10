using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public int TariffPlanId { get; set; }
        public virtual TariffPlan TariffPlan { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public override string ToString()
        {
            return $"{CompanyName} (Phone: {Phone})";
        }
    }
}
