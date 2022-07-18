using GamerShopAPI.Utils;
using System.ComponentModel.DataAnnotations;

namespace GamerShopAPI.Entities
{
    public class Category : IId
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public List<Subcategory> Subcategory { get; set; }
    }
}
