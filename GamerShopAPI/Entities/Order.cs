using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static GamerShopAPI.Utils.EnumUtils;

namespace GamerShopAPI.Entities
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public OrderStatus OrderStatus { get; set; }

        public string ShippingName { get; set; }
        public string ShippingLastname { get; set; }
        public string ShippingStatus { get; set; }
        public string ShippingCost { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingZip { get; set; }
        public string ShippingComments { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        public List<OrderProduct> OrdersProducts { get; set; }
    }
}
