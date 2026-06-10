using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Refrigerator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Refrigerator_Id { get; set; }
        [Required]
        public string Refrigerator_Name { get; set; }

        public virtual ICollection<Batch> Batches { get; set; } = new HashSet<Batch>();
        public virtual ICollection<Refrigerator_Log> Logs { get; set; } = new HashSet<Refrigerator_Log>();

        public override string ToString()
        {
            return Refrigerator_Name;
        }
    }
}
