using System.ComponentModel.DataAnnotations;

namespace eCommerceSamotNet8.Entities
{
    public class DeliveryAddress
    {
        [Key]
        public int DeliveryId { get; set; }
        public string? AddLine1 { get; set; }
        public string? AddLine2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
    }
}
