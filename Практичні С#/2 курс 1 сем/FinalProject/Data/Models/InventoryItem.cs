using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class InventoryItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Quantity { get; set; }
        public DateTime ArrivalDate { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int StorageBinId { get; set; }
        public virtual StorageBin StorageBin { get; set; }
        public override string ToString()
        {
            return $"Item: {Id} ({Quantity})";
        }
    }
}
