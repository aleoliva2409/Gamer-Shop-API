using GamerShopAPI.Utils;
using System.ComponentModel.DataAnnotations;

namespace GamerShopAPI.Entities
{
    public class Product : IId
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

        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public int SubcategoryId { get; set; }
        public Subcategory Subcategory { get; set; }
        public List<Review> Reviews { get; set; }
        public List<OrderProduct> OrdersProducts { get; set; }
    }
}
