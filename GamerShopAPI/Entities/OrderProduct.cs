using System.ComponentModel.DataAnnotations;

namespace GamerShopAPI.Entities
{
    public class OrderProduct
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public float UnitPrice { get; set; }

        [Required]
        public float TotalPrice { get; set; }
    }
}
