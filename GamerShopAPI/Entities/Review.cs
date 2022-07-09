using System.ComponentModel.DataAnnotations;

namespace GamerShopAPI.Entities
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        [StringLength(140)]
        public string Comment { get; set; }
    }
}
