using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Warehouse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } 
        public string Address { get; set; }

        public virtual ICollection<StorageZone> Zones { get; set; }
        public override string ToString()
        {
            return Name; 
        }
    }
}
