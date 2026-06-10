using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Batch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Batch_Id { get; set; }
        [Required]
        public string Batch_Num { get; set; }
        [Required]
        public DateTime Arrival_Date { get; set; }
        [Required]
        public DateTime Expiri_Date { get; set; }
        [Required]
        public int Alert_Quantity { get; set; }
        [Required]
        public int Stock_Quantity { get; set; }
        [Required]
        public decimal Unit_Price { get; set; } 

        [Required]
        public int Initial_Quantity { get; set; }

        [NotMapped]
        public decimal Unit_Price_Per_Item
        {
            get
            {
                return Initial_Quantity > 0 ? Unit_Price / Initial_Quantity : Unit_Price;
            }
        }

        public int MedicineId { get; set; }
        public virtual Medicine Medicine { get; set; }

        public int Purchase_OrderId { get; set; }
        public virtual Purchase_Order Purchase_Order { get; set; }

        public int? Purchase_Order_ItemId { get; set; }
        public virtual Purchase_Order_Item Purchase_Order_Item { get; set; }

        public int? RefrigeratorId { get; set; }
        public virtual Refrigerator Refrigerator { get; set; }

        public virtual ICollection<Sale> Sales { get; set; } = new HashSet<Sale>();

        public override string ToString()
        {
            return $"Batch:{Batch_Num} Arrive at:{Arrival_Date} ({Stock_Quantity} units)";
        }
    }
}
