using System.ComponentModel.DataAnnotations;

namespace GamerShopAPI.DTOs
{
    public class ProductDTO
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

        public string Description { get; set; }

        [Required]
        public int Stock { get; set; }

        public CategoryDTO Category { get; set; }
    }
}
