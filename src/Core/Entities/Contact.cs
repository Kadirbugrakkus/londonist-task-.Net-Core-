using System.ComponentModel.DataAnnotations;

namespace CrmApp.Core.Entities
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string? LastName { get; set; }

        [Required]
        public int CountryId { get; set; }

        [Required]
        [StringLength(20)]
        public string? Phone { get; set; }

        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }

        [Required]
        [StringLength(50)]
        public string? Budget { get; set; }

        public int BedroomsCount { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [DataType(DataType.DateTime)]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [DataType(DataType.DateTime)]
        public DateTime? DeletedAt { get; set; }
    }
}
