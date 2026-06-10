using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Specialization
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SpecializationId { get; set; }

        [Required]
        [MaxLength(100)]
        public string SpecializationName { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public virtual ICollection<SpecializationCategory> SpecializationCategories { get; set; } = new List<SpecializationCategory>();

        public override string ToString()
        {
            return SpecializationName;
        }
    }
}
