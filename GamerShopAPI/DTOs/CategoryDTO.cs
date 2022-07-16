using System.ComponentModel.DataAnnotations;

namespace GamerShopAPI.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public List<SubcategoryDTO> Subcategories { get; set; }
    }
}
