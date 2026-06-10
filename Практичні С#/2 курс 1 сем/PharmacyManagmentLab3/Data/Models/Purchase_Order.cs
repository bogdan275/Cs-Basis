using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Purchase_Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Purchase_Order_Id { get; set; }
        public DateTime Order_Date { get; set; }
        public string Status { get; set; }
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<Purchase_Order_Item> Items { get; set; }

        public override string ToString()
        {
            return $"Order {Purchase_Order_Id} ({Order_Date}), Status:{Status}";
        }
    }
}
