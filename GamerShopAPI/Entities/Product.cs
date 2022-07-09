using System.ComponentModel.DataAnnotations;

namespace GamerShopAPI.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Brand { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public int Stock { get; set; }
    }
}
