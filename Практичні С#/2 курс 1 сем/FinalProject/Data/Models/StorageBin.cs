using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class StorageBin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; } 
        public decimal MaxVolume { get; set; } 
        public decimal MaxWeight { get; set; } 

        public int StorageZoneId { get; set; }
        public virtual StorageZone StorageZone { get; set; }
        public virtual ICollection<InventoryItem> Items { get; set; }

        public override string ToString()
        {
            return $"{Code} (Max: {MaxWeight}kg)";
        }
    }
}
