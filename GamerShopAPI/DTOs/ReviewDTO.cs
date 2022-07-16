using System.ComponentModel.DataAnnotations;

namespace GamerShopAPI.DTOs
{
    public class ReviewDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(140)]
        public string Comment { get; set; }
    }
}
