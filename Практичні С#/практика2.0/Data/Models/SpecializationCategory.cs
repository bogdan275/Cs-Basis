using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class SpecializationCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int SpecializationId { get; set; }
        public virtual Specialization Specialization { get; set; }

        public int CategoryId { get; set; }
        public virtual ServiceCategory Category { get; set; }

        public override string ToString()
        {
            return $"{Specialization?.SpecializationName} from {Category?.CategoryName}";
        }
    }
}
