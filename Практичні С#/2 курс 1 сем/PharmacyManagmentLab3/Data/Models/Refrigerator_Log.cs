using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Refrigerator_Log
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Log_Id { get; set; }
        [Required]
        public double Min_Temp { get; set; }
        [Required]
        public double Max_Temp { get; set; }
        [Required]
        public double Current_Temp { get; set; }
        [Required]
        public DateTime Log_Date { get; set; }

        public int RefrigeratorId { get; set; }
        public Refrigerator Refrigerator { get; set; }

        public override string ToString()
        {
            return $"Id: {Log_Id} Current Temp: {Current_Temp} Log Date: {Log_Date}]";
        }
    }
}
