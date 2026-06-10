using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class OutboundOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        public override string ToString()
        {
            return $"Outbound order: {Id}, status{Status}";
        }
    }
}
