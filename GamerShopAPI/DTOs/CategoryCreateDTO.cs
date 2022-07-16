using System.ComponentModel.DataAnnotations;

namespace GamerShopAPI.DTOs
{
    public class CategoryCreateDTO
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
