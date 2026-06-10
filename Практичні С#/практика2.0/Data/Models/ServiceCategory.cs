using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class ServiceCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CategoryName { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        //[MaxLength(50)]
        //public string IconName { get; set; }

        public virtual ICollection<Service> Services { get; set; } = new List<Service>();
        public virtual ICollection<SpecializationCategory> SpecializationCategories { get; set; } = new List<SpecializationCategory>();

        public override string ToString()
        {
            return CategoryName;
        }
    }
}
