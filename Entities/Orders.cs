namespace eCommerceSamotNet8.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Orders
    {
        [Key]
        public int OrderId { get; set; }

        public int? UserId { get; set; }

        public int? SellerId { get; set; }

        public int? DeliveryAddressId { get; set; }
        public string? Contact { get; set; }

        public DateTime? DateTime { get; set; }
        public string? Status { get; set; }

        [ForeignKey("UserId")]
        public virtual Users User { get; set; }

        [ForeignKey("DeliveryAddressId")]
        public virtual DeliveryAddress DeliveryAddress { get; set; }

    }
}
