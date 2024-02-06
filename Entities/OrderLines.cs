using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace eCommerceSamotNet8.Entities
{
    public class OrderLines
    {
        [Key, Column(Order = 0)]

        public int LineId { get; set; }
        [Column(Order = 1)]
        public int OrderId { get; set; }

        [Column(Order = 2)]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }
        [Required]
        public string? Status { get; set; }

        [ForeignKey("OrderId")]
        public virtual Orders? Order { get; set; }

        [ForeignKey("ProductId")]
        public virtual Products? Product { get; set; }
    }
}
