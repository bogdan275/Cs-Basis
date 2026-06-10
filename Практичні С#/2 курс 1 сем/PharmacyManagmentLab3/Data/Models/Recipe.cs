using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Recipe_Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Doctor_Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Doctor_Phone { get; set; }
        [Required]
        public bool Can_use_alternative { get; set; }

        public int MedicineId { get; set; }
        public virtual Medicine Medicine { get; set; }

        public override string ToString()
        {
            return $"Doctor Name: {Doctor_Name}";
        }
    }
}
