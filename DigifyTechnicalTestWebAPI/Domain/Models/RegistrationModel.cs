using System.ComponentModel.DataAnnotations;

namespace DigifyWebAPI.Domain.Models
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

        public string? NPWPFilePath { get; set; }
        public string? PowerOfAttorneyFilePath { get; set; }
    }
}
