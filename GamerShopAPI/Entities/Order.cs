using System.ComponentModel.DataAnnotations;

namespace GamerShopAPI.Entities
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
