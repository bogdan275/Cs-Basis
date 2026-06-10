using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Shelf_Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Shelf_Item_Id { get; set; }
        public int Face_Required { get; set; }
        public int Face_Current { get; set; }

        [MaxLength(50)]
        public string? Location_Hint { get; set; }
        public DateTime Last_Updated { get; set; } = DateTime.Now;

        public int ShelfId { get; set; }
        public virtual Shelf Shelf { get; set; }
        public int MedicineId { get; set; }
        public virtual Medicine Medicine { get; set; }

        public override string ToString()
        {
            return $"Id: {Shelf_Item_Id} Last Updated: {Last_Updated}";
        }
    }
}
