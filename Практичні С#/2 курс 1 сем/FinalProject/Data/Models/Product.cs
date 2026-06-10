using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string SKU { get; set; }
        public string? Description { get; set; }


        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        [NotMapped]
        public decimal VolumePerUnit => Length * Width * Height;

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        public virtual ICollection<InventoryItem> InventoryItems { get; set; }

        public override string ToString()
        {
            return $"{Name} [SKU: {SKU}]";
        }
    }
}
