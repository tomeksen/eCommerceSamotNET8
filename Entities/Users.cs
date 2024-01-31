namespace eCommerceSamotNet8.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Users
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }

        public string? PhoneNum { get; set; }

        public int? Age { get; set; }

        public DateTime? BirthDate { get; set; }

        public string? Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Language { get; set; }

        [Required]
        public string Gender { get; set; }

        public string? AboutYou { get; set; }

        public string? UploadPhoto { get; set; }

        public bool? AgreeTc { get; set; }

        [Required]
        public string Role { get; set; }

        public string? AddressAddLine1 { get; set; }

        public string? AddressAddLine2 { get; set; }

        public string? AddressCity { get; set; }

        public string? AddressState { get; set; }

        public string? AddressZipCode { get; set; }
    }

}
