using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Return_Policy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Return_Policy_Id { get; set; }
        [Required]
        public bool Can_Return { get; set; }
        public string? Reason { get; set; }
        [Required]
        [MaxLength(100)]
        public string Signature1 { get; set; }
        [Required]
        [MaxLength(100)]
        public string Signature2 { get; set; }
        [Required]
        public string Pasport_Data { get; set; }

        [Required]
        public int SaleId { get; set; }
        public Sale Sale { get; set; }

        public override string ToString()
        {
            return $"Return Policy {Return_Policy_Id}";
        }
    }
}
