using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eCommerceSamotNet8.Entities
{
    public class OrderLines
    {
        [Key,Column(Order = 0)]
        public int OrderId { get; set; }

        [Key, Column(Order = 1)]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }
        [Required]
        public string status { get; set; }

        [ForeignKey("OrderId")]
        public virtual Orders Order { get; set; }

        [ForeignKey("ProductId")]
        public virtual Products Product { get; set; }
    }
}
