using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Medicine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Storage_Conditions { get; set; }
        [Required]
        public bool Is_Child_form { get; set; }
        [Required]
        [MaxLength(50)]
        public string Seasonal_Status { get; set; }
        [Required]
        public int Dosage { get; set; } // in mg
        [Required]
        [MaxLength(100)]
        public string Release_Form { get; set; }
        public bool Prescription_Required { get; set; }

        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }

        public int Active_IngredientId { get; set; }
        public virtual Active_Ingredient Active_Ingredient { get; set; }

        public virtual ICollection<Batch> Batches { get; set; } = new List<Batch>();
        public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
        public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();

        public override string ToString()
        {
            return $"{Name} ({Dosage}) mg";
        }
    }
}
