using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Shelf
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShelfId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Zone { get; set; }

        public int ShelfNumber { get; set; }
        public int RowNumber { get; set; }


        public virtual ICollection<Shelf_Item> ShelfItems { get; set; } = new List<Shelf_Item>();

        public override string ToString()
        {
            return $"Id: {ShelfId}, Zone: {Zone}";
        }
    }
}
