using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class IncidentComment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentId { get; set; }

        public int IncidentId { get; set; }
        public virtual Incident Incident { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        [Required]
        [MaxLength(2000)]
        public string CommentText { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public bool IsInternal { get; set; } = false;

        [MaxLength(500)]
        public string? AttachmentPath { get; set; }

        public override string ToString()
        {
            return $"{Employee?.FullName} - {CreatedAt:yyyy-MM-dd HH:mm}: {CommentText.Substring(0, Math.Min(50, CommentText.Length))}...";
        }
    }
}
