using System.ComponentModel.DataAnnotations;

namespace GamerShopAPI.DTOs
{
    public class SubcategoryDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
