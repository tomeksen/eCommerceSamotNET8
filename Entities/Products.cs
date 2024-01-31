namespace eCommerceSamotNet8.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        public string? UploadPhoto { get; set; }

        public string? ProductDesc { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Mrp { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Dp { get; set; }

        [Required]
        public string Status { get; set; }
    }

}
