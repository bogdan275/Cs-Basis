using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class StockMovement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime MovementDate { get; set; }
        public string Type { get; set; } 

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int Quantity { get; set; }

        public int? FromBinId { get; set; }
        public virtual StorageBin FromBin { get; set; }

        public int? ToBinId { get; set; }
        public virtual StorageBin ToBin { get; set; }

        public override string ToString()
        {
            return $"{MovementDate:d} | {Type}: {Product.Name} (x{Quantity})";
        }
    }
}
