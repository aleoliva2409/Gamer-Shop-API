using GamerShopAPI.Utils;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GamerShopAPI.Entities
{
    public class Review : IId
    {
        public int Id { get; set; }

        [Required]
        [StringLength(140)]
        public string Comment { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
