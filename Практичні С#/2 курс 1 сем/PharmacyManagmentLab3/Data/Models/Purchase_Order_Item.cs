using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Purchase_Order_Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Purchase_Order_Item_Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int Purchase_orderId { get; set; }
        public virtual Purchase_Order Purchase_Order { get; set; }
        public int MedicineId { get; set; }
        public virtual Medicine Medicine { get; set; }

        public override string ToString()
        {
            return $"{Purchase_Order_Item_Id} Quantity: {Quantity}]";
        }
    }
}
