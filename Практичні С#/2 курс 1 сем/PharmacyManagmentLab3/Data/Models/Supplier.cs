using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierId { get; set; }
        [Required]
        [MaxLength(255)]
        public string SupplierName { get; set; }
        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }

        public override string ToString()
        {
            return SupplierName;
        }
    }
}
