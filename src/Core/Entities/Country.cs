using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CrmApp.Core.Entities
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Required]
        [Unicode]
        [StringLength(2)]
        public string? Code { get; set; }



        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [DataType(DataType.DateTime)]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [DataType(DataType.DateTime)]
        public DateTime? DeletedAt { get; set; }
    }
}
