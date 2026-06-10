using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Sale_Id { get; set; }
        public DateTime Date_Of_Sale { get; set; }
        public int Quantity { get; set; }
        public string Customer_Name { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; } 

        public int MedicineId { get; set; }
        public virtual Medicine Medicine { get; set; }

        public int BatchId { get; set; }
        public virtual Batch Batch { get; set; }

        public int? Return_Policy_Id { get; set; }
        public virtual Return_Policy Return_Policy { get; set; }

        public override string ToString()
        {
            return $"Id: {Sale_Id} Date: {Date_Of_Sale} Quantity: {Quantity} Price: {Price}";
        }
    }
}
