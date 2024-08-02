using System.ComponentModel.DataAnnotations;

namespace CrmApp.Core.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        [EmailAddress]  // E-posta doğruluğunu kontrol etmek için
        [StringLength(100)]
        public string? Email { get; set; }

        [Required]
        [StringLength(100)]
        public string? Password { get; set; }

        [Required]
        [StringLength(100)]
        public string? Username { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [DataType(DataType.DateTime)]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [DataType(DataType.DateTime)]
        public DateTime? DeletedAt { get; set; }
    }
}
