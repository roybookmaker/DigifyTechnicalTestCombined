using System.ComponentModel.DataAnnotations;

namespace DigifyWebAPP.Models
{
    public class Registration
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string CompanyName { get; set; }

        [Required]
        public required string NPWP { get; set; }

        [Required]
        public required string DirectorName { get; set; }

        [Required]
        public required string PICName { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [Phone]
        public required string PhoneNumber { get; set; }

        public required string NPWPFilePath { get; set; }
        public required string PowerOfAttorneyFilePath { get; set; }
    }
}
